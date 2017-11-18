<#
.SYNOPSIS
This is a psake bootstrap script designed to be run on a windows machine or a enviroment.
#>

Param(
    [Alias('t')]
	[string[]]$Tasks = @("default"),

	[Alias('s')]
	[hashtable]$Secrets = @{},

	[Alias('c')]
	[string]$Configuration = "Release",

    [Alias('n', "nuget")]
    [string]$NugetVersion = "4.3.0",

	[Alias("sc", "sk")]
	[switch]$SkipCompilation,

	[switch]$Major,
	[switch]$Minor,
	[switch]$Help,
	[switch]$InteractiveMode
)

Write-Host "user: $env:USERNAME";
Write-Host "machine: $env:COMPUTERNAME";
Write-Host "configuration: $Configuration";

# Assigning Variables
$branchName = $env:BUILD_SOURCEBRANCHNAME;
if ([string]::IsNullOrEmpty($branchName))
{
	$results = (& git branch);
	$regex = New-Object Regex('\*\s*(?<name>\w+)');
	if ($regex.IsMatch($results)) { $branchName = $regex.Match($results).Groups["name"].Value; }
}
Write-Host "branch: '$branchName'";

# Restoring packages
$nuget = "$PSScriptRoot\tools\NuGet\$NugetVersion\nuget.exe";
if (-not (Test-Path $nuget -PathType Leaf))
{
	$nugetDir = Split-Path $nuget -Parent;
	if (-not (Test-Path $nugetDir -PathType Container)) { New-Item $nugetDir -ItemType Directory | Out-Null; }
	Invoke-WebRequest "https://dist.nuget.org/win-x86-commandline/v$NugetVersion/nuget.exe" -OutFile $nuget;
}

if (-not $SkipCompilation) { &$nuget restore "$((Get-Item "$PSScriptRoot\*.sln").FullName)" | Out-Null; }

# Invoking Psake
Get-Item "$PSScriptRoot\packages\psake*\tools\psake.psd1" | Import-Module -Force;
$taskFile = "$PSScriptRoot\build\tasks.ps1";

if ($Help) { Invoke-psake -buildFile $taskFile -docs; }
else
{
	Invoke-psake $taskFile -taskList $Tasks -nologo `
		-properties @{
			"Nuget"=$nuget;
			"Secrets"=$Secrets;
			"BranchName"=$branchName;
			"Major"=$Major.IsPresent;
			"Minor"=$Minor.IsPresent;
			"Configuration"=$Configuration;
			"SkipCompilation"=$SkipCompilation.IsPresent;
			"InteractiveMode"=$InteractiveMode.IsPresent;
		}

    if(-not $psake.build_success) { exit 1; }
}
