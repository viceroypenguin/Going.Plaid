# Project-Specific tasks.

Properties {
    $Packages = @("Ncrement", "VSSetup", "Pester");
	#[string]$MigrationDirectory = (Join-Path $RootDir "src/*/*Migrations" | Resolve-Path);
}

Task "Default" -depends @("clean", "msbuild", "mstest", "pack");

Task "Deploy" -alias "publish" -description "This task publishes all packages to their respective platforms." `
-depends @("clean", "configure", "version", "msbuild", "mstest", "pack", "push-nuget", "push-db", "push-web", "push-ps", "tag");

# ==============================


Task "Initialize-Solution" -alias "configure" -description "This task creates all missing user-specific artifacts." `
-depends @("restore") -action {
    # Create the 'secrets.json' file.
    if (-not (Test-Path $SecretsJson))
    {
        $credentials = '{ "jdbcurl": "jdbc:mysql://{0}/{1}", "userStore": "server=;user=;password=;database=;", "database": "server=;user=;password=;database=;" }';
        [string]::Format('{{ "nugetKey": null, "psGalleryKey": null, "local": {0}, "preview": {0} }}', $credentials) | Out-File $SecretsJson -Encoding utf8;
    }
}


Task "Clean-Solution" -alias "clean" -description "This task removes all generated artifacts from the solution." `
-precondition { return (-not $SkipClean); } -action {
    $transientFolders = @($ArtifactsDir);
    $transientFolders += (Join-Path $RootDir "packages");
	
	foreach ($proj in Get-ChildItem $RootDir -Recurse -Filter "*.*proj")
	{
		$transientFolders += (Join-Path $proj.DirectoryName "bin");
		$transientFolders += (Join-Path $proj.DirectoryName "obj");
		$transientFolders += (Join-Path $proj.DirectoryName "node_modules");
		$transientFolders += (Join-Path $proj.DirectoryName "package-lock.json");
	}

	foreach ($folder in $transientFolders)
	{
		if (Test-Path $folder)
		{
			Remove-Item $folder -Recurse -Force -ErrorAction SilentlyContinue | Out-Null;
			Write-Host "  * removed '$folder'";
		}
	}
}

# ==============================

Task "Package-Solution" -alias "pack" -description "This task generates all deployment packages." `
-depends @("restore") -action {
	if (Test-Path $ArtifactsDir) { Remove-Item $ArtifactsDir -Recurse -Force; }
	New-Item $ArtifactsDir -ItemType Directory | Out-Null;
	
	$proj = Get-Item "$RootDir\src\*\*.csproj";
	Write-Header "dotnet: pack '$($proj.BaseName)'";
    $version = Get-NcrementManifest $ManifestJson | Convert-NcrementVersionNumberToString $Branch -AppendSuffix;
	Exec { &dotnet pack $proj.FullName --output $ArtifactsDir --configuration $Configuration /p:PackageVersion=$version; }
}


Task "Rebuild-FlywayLocalDb" -alias "rebuild-db" -description "This task rebuilds the local database using flyway." `
-depends @("restore") -action{
	[string]$flyway = Get-Flyway;
	$credential = Get-Secret "local";
	Assert (-not [string]::IsNullOrEmpty($credential.database)) "A connection string for your local database was not provided.";

	$db = [ConnectionInfo]::new($credential, $credential.database);
	Write-Header "flyway: clean ($($db.ToFlywayUrl()))";
	Exec { &$flyway clean $db.ToFlywayUrl() $db.ToFlyUser() $db.ToFlyPassword(); }
	Write-Header "flyway: migrate ($($db.ToFlywayUrl()))";
	Exec { &$flyway migrate $db.ToFlywayUrl() $db.ToFlyUser() $db.ToFlyPassword() $([ConnectionInfo]::ConvertToFlywayLocation($MigrationDirectory)); }
	Exec { &$flyway info $db.ToFlywayUrl() $db.ToFlyUser() $db.ToFlyPassword() $([ConnectionInfo]::ConvertToFlywayLocation($MigrationDirectory)); }
}


Task "Run-Benchmarks" -alias "benchmark" -description "This task runs all project benchmarks." `
-depends @("restore") -action {
	$benchmarkProject = Get-ChildItem "$RootDir/tests" -Recurse -Filter "*Benchmark.csproj" | Select-Object -First 1;

	if (Test-Path $benchmarkProject.FullName)
	{
		Write-Header "dotnet: clean + build";
        [string]$sln = Resolve-Path "$RootDir/*.sln";
		Exec { &dotnet clean $sln; }
		Exec { &dotnet build $sln --configuration Release; }

		try
		{
			$dll = Get-ChildItem "$($benchmarkProject.DirectoryName)/bin/Release" -Recurse -Filter "*Benchmark.dll" | Select-Object -First 1;
			Push-Location $dll.DirectoryName;

			Write-Header "dotnet: run benchmarks";
			Exec { &dotnet $dll.FullName; }

			# Copying benchmark results to report.
			$reportFile = Get-Item "$($benchmarkProject.DirectoryName)/*.md";
			if (Test-Path $reportFile)
			{
				$summary = Get-Item "$($dll.DirectoryName)/*artifacts*/*/*.md" | Get-Content | Out-String;
				$report = $reportFile | Get-Content | Out-String;
				$match = [Regex]::Match($report, '(?i)#+\s+(Summary|Results?|Report)');
				$report = $report.Substring(0, ($match.Index + $match.Length));
				"$report`r`n`r`n$summary" | Out-File $reportFile -Encoding utf8;
				Get-Item "$($dll.DirectoryName)/*artifacts*/*/*.html" | Invoke-Item;
			}
		}
		finally { Pop-Location; }
	}
    else { Write-Host " no benchmarks found." -ForegroundColor Yellow; }
}