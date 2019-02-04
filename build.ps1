<#
.SYNOPSIS
A psake bootstraper; This script runs one or more tasks defined in the psake file.

.EXAMPLE
.\build.ps1 -Help;
This example prints a list of all the available tasks.
#>

Param(
	[Alias('t')]
	[string[]]$Tasks = @("default"),

    [Alias('s', "keys")]
	[hashtable]$Secrets = @{},

	[Alias('c')]
	[ValidateSet("Debug", "Release")]
	[string]$Configuration = "Release",

    [Alias('p')]
    [string]$Platform = "AnyCPU",

	[Alias("sc", "no-build")]
	[switch]$SkipCompilation,

    [Alias('h', '?')]
    [switch]$Help,

    [Alias('no-commit')]
    [switch]$NoCommit,
	
	[string]$TaskFile = "$PSScriptRoot/build/_.psake.ps1",
    [switch]$DeleteExistingFiles,
	[switch]$NonInteractive,
    [switch]$SkipClean,
	[switch]$Debug,
	[switch]$Major,
	[switch]$Minor
)

if ($Debug) { $Configuration = "Debug"; }

# Getting the current branch of source control.
$branchName = $env:BUILD_SOURCEBRANCHNAME;
if ([string]::IsNullOrEmpty($branchName))
{
	$match = [Regex]::Match((& git branch), '\*\s*(?<name>\w+)');
	if ($match.Success) { $branchName = $match.Groups["name"].Value; }
}

# Installing then invoking the Psake tasks.
$toolsDir = "$PSScriptRoot/tools";
$psakeModule = Join-Path $toolsDir "psake/*/*.psd1";
if (-not (Test-Path $psakeModule))
{ 
	if (-not (Test-Path $toolsDir)) { New-Item $toolsDir -ItemType Directory | Out-Null; }
	Save-Module "psake" -Path $toolsDir; 
}
Import-Module $psakeModule -Force;

if ($Help) 
{
    Invoke-Psake -buildFile $TaskFile -docs;
}
else
{
    Write-Host -ForegroundColor DarkGray "OS:            $([Environment]::OSVersion.Platform)";
	Write-Host -ForegroundColor DarkGray "User:          $([Environment]::UserName)@$([Environment]::MachineName)";
    Write-Host -ForegroundColor DarkGray "Branch:        $branchName";
    Write-Host -ForegroundColor DarkGray "Configuration: $Configuration | $Platform";

	Invoke-psake $taskFile -nologo -taskList $Tasks -properties @{
        "Secrets"=$Secrets;
		"Branch"=$branchName;
        "Platform"=$Platform;
        "ToolsDir"=$toolsDir;
        "RootDir"=$PSScriptRoot;
		"Major"=$Major.IsPresent;
		"Minor"=$Minor.IsPresent;
		"Debug"=$Debug.IsPresent;
		"Configuration"=$Configuration;
        "SkipClean"=$SkipClean.IsPresent;
        "Commit"=(-not $NoCommit.IsPresent);
		"NonInteractive"=$NonInteractive.IsPresent;
        "TempDir"=([System.IO.Path]::GetTempPath());
		"SkipCompilation"=$SkipCompilation.IsPresent;
        "SolutionName"=(Split-Path $PSScriptRoot -Leaf);
        "DeleteExistingFiles"=$DeleteExistingFiles.IsPresent;
	}
	if (-not $psake.build_success) { exit 1; }
}