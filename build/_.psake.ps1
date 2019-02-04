# SYNOPSIS: This is a psake task file.

$psakeTaskFile = (Join-Path $PSScriptRoot "tasks.psake.ps1");
if (Test-Path $psakeTaskFile -PathType Leaf) { Include $psakeTaskFile; }

Properties {
	# Constants
    $RootDir = (Split-Path $PSScriptRoot -Parent);
    $ManifestJson = (Join-Path $PSScriptRoot "manifest.json");
	$SecretsJson = (Join-Path $PSScriptRoot "secrets.json");
	$ArtifactsDir = (Join-Path $RootDir "artifacts");
    $SolutionName = "";
    $ToolsDir = "";
    $TempDir = "";

	# Args
    $DeleteExistingFiles = $false;
	$FallbackBranch = "preview";
	$SkipCompilation = $false;
	$NonInteractive = $false;
    $SkipClean = $false;
	$Configuration = "";
    $Commit = $true;
	$Debug = $false;
	$Secrets = @{ };
	$Major = $false;
	$Minor = $false;
    $Branch = "";
}

#region ----- COMPILATION -----

Task "Import-Dependencies" -alias "restore" -description "This task imports all build dependencies." `
-action {
	#  Importing all required powershell modules.
	foreach ($moduleId in $Packages)
	{
		$modulePath = "$ToolsDir/$moduleId/*/*.psd1";
		if (-not (Test-Path $modulePath))
		{
			Save-Module $moduleId -Path $ToolsDir;
		}
		Import-Module $modulePath -Force;
		Write-Host "  * imported the '$moduleId.$(Split-Path (Get-Item $modulePath).DirectoryName -Leaf)' powershell module.";
	}

    # Creating the 'manifest.json' file.
    if (-not (Test-Path $ManifestJson))
    {
        New-NcrementManifest $ManifestJson -Author $([System.Environment]::UserName) | Save-NcrementManifest $ManifestJson;
    }
}

Task "Increment-VersionNumber" -alias "version" -description "This task increments the project's version numbers" `
-depends @("restore") -action {
    $manifest = Get-NcrementManifest $ManifestJson;

    $oldVersion = $manifest | Convert-NcrementVersionNumberToString;
	$result = $manifest | Step-NcrementVersionNumber $Branch -Break:$Major -Feature:$Minor -Patch | Update-NcrementProjectFile "$RootDir/src" -Commit:$Commit;
    $newVersion = $manifest | Convert-NcrementVersionNumberToString;

	Write-Host "  * incremented version number from '$oldVersion' to '$newVersion'.";
	foreach ($file in $result.ModifiedFiles)
	{
		Write-Host "  * updated $(Split-Path $file -Leaf).";
	}
}

Task "Build-Solution" -alias "msbuild" -description "This task builds the solution." `
-depends @("restore") -precondition { return (-not $SkipCompilation); } -action {
	Write-Header "dotnet: msbuild";
	Exec { &dotnet msbuild $((Get-Item "$RootDir/*.sln").FullName) "/p:Configuration=$Configuration" "/verbosity:minimal"; }
}

Task "Run-Tests" -alias "mstest" -description "This task invoke all mstest tests." `
-depends @("restore") -action {
	try
	{
        # Running all MSTest assemblies.
        Push-Location $RootDir;
		foreach ($testFile in (Get-ChildItem "$RootDir/tests/*/bin/$Configuration" -Recurse -Filter "*$SolutionName*Test.dll"))
		{
			Write-Header "dotnet: vstest '$($testFile.BaseName)'";
			Exec { &dotnet vstest $testFile.FullName; }
		}
	}
	finally { Pop-Location; }
}

Task "Run-Pester" -alias "pester" -description "This task invokes all pester tests." `
-depends @("restore") -action {
	try
	{
        Push-Location $RootDir;
		foreach ($testFile in (Get-ChildItem "$RootDir/tests/*/" -Recurse -Filter "*tests.ps1"))
		{
			Write-Header "Pester '$($testFile.BaseName)'";
			$results = Invoke-Pester -Script $testFile.FullName -PassThru;
            if ($results.FailedCount -gt 0) { throw "'$($testFile.BaseName)' failed '$($results.FailedCount)' test(s)."; }
		}
	}
	finally { Pop-Location; }
}

#endregion

#region ----- PUBLISHING -----

Task "Publish-NuGetPackages" -alias "push-nuget" -description "This task publish all nuget packages to nuget.org." `
-precondition { return Test-Path $ArtifactsDir -PathType Container } `
-depends @("restore") -action {
	$apiKey = Get-Secret "nugetKey" -Assert;

	foreach ($nupkg in (Get-ChildItem $ArtifactsDir -Recurse -Filter "*.nupkg"))
	{
		Write-Header "dotnet: nuget push '$($nupkg.Name)'";
		Exec { &dotnet nuget push $nupkg.FullName --source "https://api.nuget.org/v3/index.json" --api-key $apiKey; }
	}
}

Task "Publish-PowershellModules" -alias "push-ps" -description "This task publish all powershell modules to powershellgallery.org." `
-depends @("restore") -action {
    $apiKey = Get-Secret "psGalleryKey" -Assert;

    foreach ($psd1 in (Get-ChildItem $ArtifactsDir -Recurse -Filter "*.psd1"))
    {
        if (Test-ModuleManifest $psd1.FullName)
        {
            Write-Header "PS: publish '$($psd1.BaseName)'";
            Publish-Module -Path $psd1.DirectoryName -NuGetApiKey $apiKey;
        }
    }
}

Task "Publish-Database" -alias "push-db" -description "This task publishes the application database to the appropriate host." `
-depends @("restore", "rebuild-db") -action {
	$credentials = $null;
	foreach ($key in @($Branch, $FallbackBranch))
	{
		$credentials = Get-Secret $key;
		if (-not [string]::IsNullOrEmpty($credentials)) { break; }
	}
	Assert(-not [string]::IsNullOrEmpty($credentials.database)) "Unable to update database because no connection info was provided for the '$Branch' branch. Verify the secrets.json file.";
	$db = [ConnectionInfo]::new($credentials, $credentials.database);
	
    Write-Header "flyway: migrate ($($db.ToFlywayUrl()))";
	[string]$flyway = Get-Flyway;
	Exec { &$flyway migrate $db.ToFlywayUrl() $db.ToFlyUser() $db.ToFlyPassword() $([ConnectionInfo]::ConvertToFlywayLocation($MigrationDirectory)); }
	Exec { &$flyway info $db.ToFlywayUrl() $db.ToFlyUser() $db.ToFlyPassword() $([ConnectionInfo]::ConvertToFlywayLocation($MigrationDirectory)); }
}

Task "Publish-Websites" -alias "push-web" -description "This task publish all websites to their respective host." `
-depends @("restore")  -action {
    Assert (Test-Path $ArtifactsDir -PathType Container) "No website packages have been generated; try invoking the 'pack' task first.";

	foreach ($package in (Get-ChildItem $ArtifactsDir -Recurse -Filter "website-*"))
	{
		$id = $package.BaseName.TrimStart("website-");

        $key = '';
		$credentials = $null;
		$errorMsg = "Unable to publish '$($package.Name)' because the web-host password was not defined. Verify the secrets.json.";

		foreach ($key in @($Branch, $FallbackBranch))
		{
			$credentials = Get-Secret $key;
			if (($credentials -eq $null) -or ($credentials.PSObject.Properties.Match($id) -eq $null)) { continue; }
			$webHost = [ConnectionInfo]::new($credentials, $credentials.$id);
			if ([string]::IsNullOrEmpty($webHost.Password)) { throw $errorMsg; } else { break; }
		}

		[string]$publishData = Get-ChildItem $PSScriptRoot -Recurse -Filter "*$id-$key.publishsettings" | Select-Object -First 1 -ExpandProperty FullName;
		if ([string]::IsNullOrEmpty($publishData)) { throw "Unable to publish '$($package.BaseName)' because a respective .publshsetting file do not exist."; }
		else
		{
            [string]$waws = Get-WAWSDeploy;
            $del = $DeleteExistingFiles | CND "/deleteexistingfiles" '';
			Exec { &$waws $package.FullName $publishData /password $webHost.Password /appoffline $del; }
			if (-not $NonInteractive)
			{
				[xml]$doc = Get-Content $publishData;
				$websiteUrl = $doc.SelectSingleNode("//publishProfile[@destinationAppUrl]").Attributes["destinationAppUrl"].Value;
                if (-not [string]::IsNullOrEmpty($websiteUrl))
                {
                    Start-Process $websiteUrl;
                }
			}
		}
	}
}

Task "Tag-Release" -alias "tag" -description "This task tags the last commit with the version number." `
-depends @("restore") -action {
    $version = Get-NcrementManifest $ManifestJson | Convert-NcrementVersionNumberToString;
    Write-Header "git: push 'v$version'";
    
    if ($Branch -ieq "master")
    {
        Exec { &git tag v$version | Out-Null; }
        Exec { &git push "origin" | Out-Null; }
        Exec { &git push "origin" --tags | Out-Null; }
    }
    else
    {
        Exec { &git push "origin" | Out-Null; }
    }
}

#endregion

#region ----- FUNCTIONS -----

function Get-MSBuild([string]$version = "*")
{
    $instance = Get-VSSetupInstance -All | Select-VSSetupInstance -Latest;
    return (Join-Path $instance.InstallationPath "msbuild/$version/bin/msbuild.exe" | Resolve-Path) -as [string];
}

function Get-Dotfuscator()
{
    $instance = Get-VSSetupInstance -All | Select-VSSetupInstance -Latest;
    $dotfuscator = Join-Path $instance.InstallationPath "Common7/IDE/Extensions/PreEmptiveSolutions/DotfuscatorCE/dotfuscatorCLI.exe";

    return (Test-Path $dotfuscator) | CND $dotfuscator "";
}

function Get-Flyway([string]$version="5.1.4")
{
	[string]$flyway = Join-Path $ToolsDir "flyway/$version/flyway";
    [string]$url = "http://repo1.maven.org/maven2/org/flywaydb/flyway-commandline/{1}/flyway-commandline-{1}-{0}-x64.zip";
    switch ([Environment]::OSVersion.Platform)
    {
        default 
        {
            $flyway = "$flyway.cmd";
            $url = [string]::Format($url, "windows", $version);
        }
        $([PlatformId]::Unix)
        {
            $url = [string]::Format($url, "linux", $version);
        }
        $([PlatformId]::MacOSX)
        {
            $url = [string]::Format($url, "macosx", $version);
        }
    }

	if (-not (Test-Path $flyway))
	{
		$zip = Join-Path $TempDir "flyway-$version.zip";
		try
		{
			Invoke-WebRequest $url -OutFile $zip;

			$dest = Join-Path $ToolsDir "flyway";
			Expand-Archive $zip -DestinationPath $dest -Force;
			Get-Item "$dest/*" | Rename-Item -NewName $version;
		}
		finally { if (Test-Path($zip)) { Remove-Item $zip -Force; } }
	}

    return $flyway;
}

function Get-WAWSDeploy([string]$version="1.8.0")
{
	[string]$waws = Join-Path $ToolsDir "WAWSDeploy/$version/tools/WAWSDeploy.exe";

	if (-not (Test-Path $waws))
	{
		$zip = Join-Path $TempDir "wawsdeploy.zip";
		try
		{
			Invoke-WebRequest "https://chocolatey.org/api/v2/package/WAWSDeploy/$version" -OutFile $zip;
			Expand-Archive $zip -DestinationPath (Join-Path $ToolsDir "WAWSDeploy/$version") -Force;
		}
		finally { if (Test-Path $zip) { Remove-Item $zip -Force; } }
	}

    return $waws;
}

function Get-Nuget([string]$version = "latest")
{
	[string]$nuget = Join-Path $ToolsDir "Nuget/$version/nuget.exe";

	if (-not (Test-Path $nuget))
	{
		$dir = Split-Path $nuget -Parent;
		if (-not (Test-Path $dir)) { New-Item $dir -ItemType Directory | Out-Null; }
		Invoke-WebRequest "https://dist.nuget.org/win-x86-commandline/$version/nuget.exe" -OutFile $nuget;
	}

	return $nuget;
}

function Get-Secret([Parameter(ValueFromPipeline)][string]$key, [string]$customMsg = "", [switch]$Assert)
{
	$value = $Secrets.ContainsKey($key) | CND $Secrets.$key $null;
	if ([string]::IsNullOrEmpty($value) -and (Test-Path $SecretsJson))
	{
		$value = Get-Content $SecretsJson | Out-String | ConvertFrom-Json | Select-Object -ExpandProperty $key -ErrorAction SilentlyContinue;
	}

	if ($Assert) { Assert (-not [string]::IsNullOrEmpty($value)) ([string]::IsNullOrEmpty($customMsg) | CND "A '$key' property was not specified. Provided a value via the `$Secrets parameter eg. `$Secrets=@{'$key'='your_sercret_value'}" $customMsg); }
	return $value;
}

function Write-Header([string]$Title = "", [int]$length = 70, [switch]$AsValue)
{
	$header = [string]::Join('', [System.Linq.Enumerable]::Repeat('-', $length));
	if (-not [String]::IsNullOrEmpty($Title))
	{
		$header = $header.Insert(4, " $Title ");
		if ($header.Length -gt $length) { $header = $header.Substring(0, $length); }
	}

	if ($AsValue) { return $header; } else { Write-Host ''; Write-Host $header -ForegroundColor DarkGray; Write-Host ''; }
}

function CND([Parameter(Mandatory, ValueFromPipeline)][bool]$Condition, [Parameter(Position = 0)]$TrueValue, [Parameter(Position = 1)]$FalseValue)
{
	if ($Condition) { return $TrueValue; } else { return $FalseValue; }
}

Class ConnectionInfo {
	ConnectionInfo($dbNode, [string]$connectionString) {
		if ([string]::IsNullOrEmpty($connectionString)) { throw "The '`$connectionString' parameter cannot be null or empty."; }

		$this.Host = [Regex]::Match($connectionString, '(?i)(server|data source|host)=(?<value>[^;]+);?').Groups["value"].Value;
		$this.User = [Regex]::Match($connectionString, '(?i)(user|usr)=(?<value>[^;]+);?').Groups["value"].Value;
		$this.Password = [Regex]::Match($connectionString, '(?i)(password|pwd)=(?<value>[^;]+);?').Groups["value"].Value;
		$this.Resource = [Regex]::Match($connectionString, '(?i)(database|catalog)=(?<value>[^;]+);?').Groups["value"].Value;
		$this.ConnectionString = $connectionString;
		$this.JDBCUrl = $dbNode.JDBCUrl;
	}

	[string]$Host;
	[string]$User;
	[string]$Password;
	[string]$Resource;
	[string]$ConnectionString;

    [string]$JDBCUrl;

	[string] ToFlywayUrl(){
		return "-url=$([string]::Format($this.JDBCUrl, $this.Host, $this.Resource))";
	}

	[string] ToFlyUser() {
		return "-user=$($this.User)";
	}

	[string] ToFlyPassword() {
		return "-password=$($this.Password)";
	}

	static [string] ConvertToFlywayLocation([string]$path) {
		return "-locations=filesystem:$path";
	}
}

#endregion

FormatTaskName "$(Write-Header -AsValue)`r`n  {0}`r`n$(Write-Header -AsValue)";