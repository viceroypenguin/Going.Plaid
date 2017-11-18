Properties {
	# Paths & Tools
	$RootDir = "$(Split-Path $PSScriptRoot -Parent)";
	$SecretsJson = "$PSScriptRoot/secrets.json";
	$ManifestJson = "$PSScriptRoot/manifest.json";
	
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
			`"nugetKey`": `"your_apikey`",
			`"plaid`":
			{
				`"client_id`": `"your_client_id`",
				`"secret`": `"your_secret`"
			}
		}
"@.Trim() | Out-File $SecretsJson -Encoding utf8;
		Write-Host "`t* created '$SecretsJson'.";
		try { Invoke-Item $SecretsJson; } catch { }
	}

	# Updating the plaid.config file.
	$secrets = Get-Content $SecretsJson | Out-String | ConvertFrom-Json;
	@" 
	<?xml version=`"1.0`" encoding=`"utf-8`"?>
	<configuration>
		<appSettings>
			<add key=`"client_id`" value=`"$($secrets.plaid.client_id)`" />
			<add key=`"secret`" value=`"$($secrets.plaid.secret)`" />
		</appSettings>
	</configuration>
"@.Trim() | Out-File "$PSScriptRoot\plaid.config" -Encoding utf8 -Force;
	Write-Host "`t* updated plaid.config";
}

Task "Build-Solution" -alias "compile" -description "" `
-depends @("restore") -precondition { return (-not $SkipCompilation); } -action {

}

Task "Run-Tests" -alias "test" -description "" `
-depends @("restore") -action {

}

#endregion

#region ----- PUBLISHING -----

Task "Create-NuGetPackages" -alias "pack" -description "" `
-depends @("restore") -action {

}

Task "Publish-Packages" -alias "push-nuget" -description "" `
-depends @("restore") -action {

}

#endregion

#region ----- Setup -----
$newline = [System.Environment]::NewLine;
$line = "----------------------------------------------------------------------";
FormatTaskName "$line$newline{0}$newline$line";
#endregion