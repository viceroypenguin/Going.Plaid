Properties {
    # Credentials
    $NugetKey = $null;

    # Paths
    $ProjectDirectory = (Split-Path $PSScriptRoot -Parent);
    $NugetPackages = "$ProjectDirectory\build\nuget";
    $TempDirectory = "$ProjectDirectory\build\Temp";
    $NugetEXE = "$ProjectDirectory\tools\nuget.exe";

    # Msbuild Args
    $BuildConfiguration = "Release";
    $BuildPlatform = "Any CPU";
}

Task default -depends Init, Create-Packages, Publish-NuGetPackages;

Task Init -description "Initialize the build n' deploy procedure." -action {
    Assert(Test-Path $ProjectDirectory -PathType Container) "`$ProjectionDirectory cannot be null or empty.";

    # Cleanup directories.
        foreach($dir in @($TempDirectory, $NugetPackages))
        {
            if(Test-Path $dir -PathType Container)
            {
               Remove-Item $dir -Force -Recurse;
               New-Item $dir -ItemType Directory | Out-Null;
            }
            else { New-Item $dir -ItemType Directory | Out-Null; }
        }
}

Task Compile -description "Build the solution." -depends Init -action {
    Assert("Debug", "Release" -contains $BuildConfiguration) "Value must be 'Debug' or 'Release'.";
    Assert("x86", "x64", "Any CPU" -contains $BuildPlatform) "Value must be 'x86', 'x64' or 'Any CPU'.";

    # Build Visual Studio solution.
    $solution = (Get-ChildItem $ProjectDirectory -Recurse -Filter "*.sln" | Select-Object -ExpandProperty FullName -First 1);
    Exec { msbuild $solution "/p:Configuration=$BuildConfiguration;Platform=$BuildPlatform" | Out-Null }
}

Task Create-Packages -description "Create nuget packages." -depends Compile -action {
    Push-Location $NugetPackages;
    foreach($project in (Get-ChildItem "$ProjectDirectory\src" -Recurse -Filter "*.csproj" | Select-Object -ExpandProperty FullName))
    {
        $nuspec = [System.IO.Path]::ChangeExtension($project, ".nuspec");
        if(Test-Path $nuspec -PathType Leaf)
        {
            Write-Host "`t* packaging $(Split-Path $project -Leaf)...";
            Exec { (& $NugetEXE pack $($project) -IncludeReferencedProjects -Prop Configuration=$($BuildConfiguration)) | Out-Null; }
        }
    }
    Pop-Location;
}

Task Publish-NuGetPackages -description "Publish nuget packages to nuget.org" -depends Init -action {
    Assert(-not [System.String]::IsNullOrEmpty($NugetKey)) "The 'NugetKey' cannot be null or empty.";

    foreach($package in (Get-ChildItem $NugetPackages | Select-Object -ExpandProperty FullName))
    {
        Exec { 
            $output = (& $NugetEXE push $($package) $($NugetKey) -Source "https://www.nuget.org");
            Write-Host "`t* $output";
        }
    }
}