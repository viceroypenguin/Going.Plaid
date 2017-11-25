Properties {
	# Paths & Tools
	$RootDir = "$(Split-Path $PSScriptRoot -Parent)";
	$ManifestJson = "$PSScriptRoot/manifest.json";
	$SecretsJson = "$PSScriptRoot/secrets.json";
	$ArtifactsDir = "$RootDir/artifacts";
	$Nuget = "";

	# Deployment Args
	$Secrets = @{};
	$Major = $false;
	$Minor = $false;
	$BranchName = "";
	$Configuration = "";
	$SkipCompilation = $false;
	$InteractiveMode = $false;
}

Task "default" -depends @("restore");

#region ----- COMPILATION -----

Task "Load-Dependencies" -alias "restore" -description "This task loads all dependencies and restore all missing files." `
-action {
	# Importing all module dependencies
	foreach ($moduleId in @("Buildbox", "VSSetup"))
	{
		$module = "$RootDir/tools/$moduleId";
		if (-not (Test-Path $module))
		{
			Save-Module $moduleId -Path "$RootDir/tools" -Force;
		}
		$module = Get-Item "$RootDir/tools/$moduleId/*/*.psd1";
		Import-Module $module -Force;
		Write-Host "`t* imported $moduleId.$(Split-Path (Split-Path $module.FullName -Parent) -Leaf) module.";
	}

	if (-not (Test-Path $ManifestJson)) { New-BuildboxManifest $ManifestJson; }

	# Re-generating secrets.json.
	if (-not (Test-Path $SecretsJson))
	{
		@"
		{
			`"nugetKey`": `"your_apikey (not needed)`",
			`"plaid`":
			{
				`"secret`": `"your_secret`",
				`"client_id`": `"your_client_id`",
				`"public_key`": `"your_public_key`",
				`"access_token`": "your_sandbox_access_token (run plaid.demo.csproj to get one)"
			}
		}
"@.Trim() | Out-File $SecretsJson -Encoding utf8;
		Write-Host "`t* created '$SecretsJson'.";
		try { Invoke-Item $SecretsJson; } catch { }
	}
}

Task "Build-Solution" -alias "compile" -description "This task builds the solution." `
-depends @("restore") -precondition { return (-not $SkipCompilation); } -action {
	Write-LineBreak "MSBuild";
	$vsPath = Get-VSSetupInstance | Select-VSSetupInstance -Latest | Select-Object -ExpandProperty InstallationPath;
	$msbuild = Get-Item "$vsPath\MSBuild\*\Bin\MSBuild.exe";
	$sln = Get-Item "$RootDir\*.sln" | Select-Object -ExpandProperty FullName;
	Exec { &$msbuild $sln "/p:Configuration=$Configuration" "/verbosity:minimal"; }
}

Task "Run-Tests" -alias "test" -description "This task runs all tests." `
-depends @("compile") -action {
	$vsPath = Get-VSSetupInstance | Select-VSSetupInstance -Latest | Select-Object -ExpandProperty InstallationPath;
	$vstest = "$vsPath\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe";

	try
	{
		Push-Location $RootDir;
		Write-LineBreak "VSTest";
		foreach ($targetDll in (Get-ChildItem "$RootDir\tests\*\bin\$Configuration" -Recurse -Filter "*mstest*dll" | Select-Object -ExpandProperty FullName))
		{
			Exec { &$vstest $targetDll /Logger:trx; }
		}
	}
	finally
	{
		Pop-Location;
	}
}

Task "Update-VersionNumber" -alias "version" -description "This task updates all projects' version numbers." `
-depends @("restore") -action {
	$results = ($ManifestJson | Get-BuildboxManifest | Update-ProjectManifests "$RootDir\src" -Major:$Major -Minor:$Minor);
	Write-Host "$Tab* incremented solution version number to '$($results.Manifest.Version.ToString())'";
	foreach ($file in $results.ModifiedFiles)
	{
		Write-Host "$Tab $Tab* updated '$(Split-Path $file -Leaf)' version number.";
	}

	if ($results.CommittedChanges)
	{
		Write-Host "$Tab* committed changes to source control.";
	}
}

#endregion

#region ----- PUBLISHING -----

Task "Create-NuGetPackages" -alias "pack" -description "This task generates all NuGet packages." `
-depends @("restore") -action {
	if (Test-Path $ArtifactsDir) { Remove-Item $ArtifactsDir -Recurse -Force; }
	New-Item $ArtifactsDir -ItemType Directory | Out-Null;

	$manifest = $ManifestJson | Get-BuildboxManifest;
	$version = $manifest.Version.ToString();
	$suffix = $manifest.GetBranchSuffix($BranchName);

	foreach ($name in @("Plaid"))
	{
		$csproj = Get-Item "$RootDir/src/$name/*.csproj";
		if ([string]::IsNullOrEmpty($suffix)) 
		{
			Exec { &dotnet pack $csproj.FullName --output $ArtifactsDir --configuration $Configuration; }
		}
		else
		{
			Exec { &dotnet pack $csproj.FullName --output $ArtifactsDir --configuration $Configuration /p:PackageVersion="$version-$suffix"; }
		}
	}
}

Task "Publish-NuGetPackages" -alias "push-nuget" -description "This task publishes all NuGet packages to nuget.org." `
-depends @("restore") -action {
	$apiKey = $Secrets.nugetKey;
	if ([string]::IsNullOrEmpty($apiKey))
	{
		$doc = Get-Content $SecretsJson | Out-String | ConvertFrom-Json;
		$apiKey = $doc.nugetKey;
	}

	Assert (Test-Path $ArtifactsDir) "no packages have been generated run the 'pack' command first.";
	Assert (-not [string]::IsNullOrEmpty($apiKey)) "the nuget api key is null or empty.";
	
	foreach ($nupkg in (Get-ChildItem $ArtifactsDir -Recurse -Filter "*.nupkg"))
	{
		#Exec { &$nuget push $nupkg.FullName -ApiKey $apiKey; }
	}
}

Task "Publish" -description "This task test then publishes the packages to nuget." `
-depends @("compile", "test", "pack", "push-nuget");

#endregion

#region ----- Setup -----
$newline = [System.Environment]::NewLine;
$line = "----------------------------------------------------------------------";
FormatTaskName "$line$newline{0}$newline$line";
#endregion