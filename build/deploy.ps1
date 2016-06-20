Properties {
    # Paths
    $ProjectDirectory = (Split-Path $PSScriptRoot -Parent);
    $TempDirectory = "$ProjectDirectory\build\Temp";
    $NugetEXE = "$ProjectDirectory\tools\nuget.exe";

    # Msbuild Args
    $BuildConfiguration = "Release";
    $BuildPlatform = "Any CPU";
}

Task default -depends Init, Compile;

Task Init -description "Initialize the build n' deploy procedure." -action {
    Assert(Test-Path $ProjectDirectory -PathType Container) "`$ProjectionDirectory cannot be null or empty.";

    # Cleanup directories.
        foreach($dir in @($TempDirectory))
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