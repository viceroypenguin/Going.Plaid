#region ----- COMPILATION -----------------------------------------------

function Invoke-MSBuild
{
	Param(
		[Parameter(Mandatory)]
		[ValidateSet("Debug", "Release")]
		[string]$Configuration,

		[string]$ToolPath,

		$PackageSources = @(),

		[Parameter(Mandatory, ValueFromPipeline)]
		[ValidateScript({Test-Path $_})]
		[IO.FileInfo]$SolutionFile
	)

	PROCESS
	{
		if ((-not [String]::IsNullOrEmpty($ToolPath)) -and (Test-Path $ToolPath -PathType Leaf))
		{
			Write-Header "msbuild: '$($SolutionFile.BaseName)'";
			Invoke-Tool { &$ToolPath $SolutionFile.FullName -target:restore; }
			Invoke-Tool { &$ToolPath $SolutionFile.FullName -property:Configuration=$Configuration; }
		}
		else
		{
			Write-Header "dotnet: build '$($SolutionFile.BaseName)'";
			Invoke-Tool{ &dotnet restore $SolutionFile.FullName --verbosity minimal; }
			Invoke-Tool { &dotnet build $SolutionFile.FullName --configuration $Configuration --verbosity minimal; }
		}
	}
}

function Invoke-MSTest
{
	Param(
		[Parameter(Mandatory)]
		[ValidateSet("Debug", "Release")]
		$Configuration,

		[Parameter(Mandatory, ValueFromPipeline)]
		[IO.FileInfo]$ProjectFile,

		[Alias('f')]
		[switch]$FullFramework
	)
	PROCESS
	{
		try
		{
			Push-Location $ProjectFile.DirectoryName;
			Write-Header "dotnet: test '$($ProjectFile.Name)'";
			Invoke-Tool { &dotnet test $ProjectFile.FullName --configuration $Configuration --verbosity minimal; };
		}
		finally { Pop-Location; }
	}
}

function Invoke-BenchmarkDotNet
{
	Param(
		[string]$Filter = "*",

		[Parameter(Mandatory, ValueFromPipeline)]
		[ValidateScript({Test-Path $_.FullName})]
		[IO.FileInfo]$ProjectFile,

		[switch]$DryRun
	)

	PROCESS
	{
		$job = "Default";
		if ($DryRun) { $job = "Dry"; }

		Invoke-Tool { &dotnet build $ProjectFile.FullName --configuration "Release"; }
		$dll = Join-Path $ProjectFile.DirectoryName "bin/Release/*/*$($ProjectFile.BaseName).dll" | Get-Item | Select-Object -Last 1;
		try
		{
			Push-Location $ProjectFile.DirectoryName;
			Write-Header "benchmark: '$($ProjectFile.BaseName)'";
			Invoke-Tool { &dotnet $dll.FullName --filter $Filter --job $job | Write-Host; }
			$report = Join-Path $PWD "BenchmarkDotNet.Artifacts/results" | Get-ChildItem -File -Filter "*vbench*.html" | Select-Object -First 1 -ExpandProperty FullName | Invoke-Item;
		}
		finally { Pop-Location; }
	}
}

function Remove-GeneratedProjectItem
{
	[CmdletBinding(SupportsShouldProcess)]
	Param(
		$AdditionalItems = @(),

		[Parameter(ValueFromPipeline)]
		[ValidateScript({Test-Path $_.FullName})]
		[IO.FileInfo]$ProjectFile
	)
	PROCESS
	{
		$itemsToBeRemoved =  (@("bin", "obj", "node_modules", "TestResults", "package-lock.json") + $AdditionalItems) | Select-Object -Unique;
		foreach ($target in $itemsToBeRemoved)
		{
			$itemPath = Join-Path $ProjectFile.DirectoryName $target;
			if ((Test-Path $itemPath) -and $PSCmdlet.ShouldProcess($itemPath))
			{
				Remove-Item $itemPath -Recurse -Force;
				Write-Host "  * removed '.../$($ProjectFile.Directory.Name)/$($target)'.";
			}
		}
	}
}

#endregion

#region ----- PUBLISHING -----------------------------------------------

function New-Tag
{
	Param([Parameter(Mandatory, ValueFromPipeline)][ValidateNotNullOrEmpty()][string]$Version)

	Invoke-Tool { &git tag "v$Version"; }
	Write-Host "  * created tag 'v$Version'.";
	Invoke-Tool { &git push origin HEAD; }
	Invoke-Tool { &git push origin "v$Version"; }
	Write-Host "  * pushed changes to source control.";
}

function Publish-NugetPackage
{
	Param(
		[Parameter(Mandatory)]
		[ValidateScript({Test-Path $_})]
		[string]$SecretsFilePath,

		[Parameter()]
		[ValidateNotNullOrEmpty()]
		[string]$Key = "nugetKey",

		[ValidateNotNullOrEmpty()]
		[string]$Source = "https://api.nuget.org/v3/index.json",

		[Parameter(Mandatory, ValueFromPipeline)]
		[ValidateScript({Test-Path $_.FullName})]
		[IO.FileInfo]$PackageFile
	)

	BEGIN { [string]$apikey = Get-Content $SecretsFilePath | ConvertFrom-Json | Select-Property $Key; }
	PROCESS
	{
		Write-Header "dotnet: nuget push '$($PackageFile.Name)'";
		Invoke-Tool { &dotnet nuget push $PackageFile.FullName --source $Source --api-key $apiKey; }
	}
}

function Publish-PowershellModule
{
	Param(
		[Parameter(Mandatory)]
		[ValidateScript({Test-Path $_})]
		[string]$SecretsFilePath,

		[Parameter(Mandatory)]
		[ValidateNotNullOrEmpty()]
		[string]$Key,

		[Parameter(Mandatory, ValueFromPipeline)]
		[ValidateScript({Test-Path $_.FullName})]
		[IO.FileInfo]$ModuleManifest
	)

	BEGIN { [string]$apikey = Get-Content $SecretsFilePath | ConvertFrom-Json | Select-Property $Key; }

	PROCESS
	{
		if (Test-ModuleManifest $ModuleManifest.FullName)
		{
			Publish-Module -Path $ModuleManifest.DirectoryName -NuGetApiKey $apikey;
			Write-Host "  * published '$($ModuleManifest.BaseName)' to https://www.powershellgallery.com/";
		}
	}
}

function Publish-VsixPackage
{
	Param(
		[Parameter(Mandatory)]
		[ValidateScript({Test-Path $_ -PathType Leaf})]
		[string]$SecretsFilePath,

		[Parameter()]
		[ValidateNotNullOrEmpty()]
		[string]$Key = "vsixGallerKey",

		[Parameter(Mandatory, ValueFromPipeline)]
		[IO.FileInfo]$Package
	)

	BEGIN
	{
		[string]$apikey = Get-Content $SecretsFilePath | ConvertFrom-Json | Select-Property $Key;
		[string]$publisher = Join-Path ([IO.Path]::GetTempPath()) "publish-vsix.ps1";

		if (-not (Test-Path $publisher -PathType Leaf))
		{
			Invoke-WebRequest "https://raw.github.com/madskristensen/ExtensionScripts/master/AppVeyor/vsix.ps1" -OutFile $publisher;
			Write-Host "  * downloaded publisher script."
		}
		. $publisher;
	}

	PROCESS
	{
		Write-Header "vsixPublisher: '$($Package.Basename)'";
		Vsix-PublishToGallery $Package.FullName;
	}
}

#endregion

#region ----- Helpers -----------------------------------------------

function Invoke-Tool
{
    param(
        [Parameter(Mandatory)]
        [scriptblock]$Action,

        [string]$WorkingDirectory = $null
    )

    if ($WorkingDirectory) { Push-Location -Path $WorkingDirectory; }

	try
	{
		$global:lastexitcode = 0;
		& $Action;
		if ($global:lastexitcode -ne 0) { throw "The command [ $Action ] throw an exception."; }
	}
	finally { if ($WorkingDirectory) { Pop-Location; } }
}

function Out-StringFormat
{
	Param(
		[Parameter(Mandatory)]
		[ValidateNotNullOrEmpty()]
		[string]$FormatString,

		$Arg1, $Arg2,

		[Parameter(ValueFromPipeline)]
		$InputObject
	)

	PROCESS
	{
		if ($InputObject)
		{
			$value = $InputObject;
			if ($InputObject | Get-Member "Name") { $value = $InputObject.Name; }
			return ([string]::Format($FormatString, @($value, $Arg1, $Arg2)));
		}
	}
}

function Out-StringHeader
{
	Param([string]$Title = "", [int]$length = 70)

	$header = [string]::Join('', [System.Linq.Enumerable]::Repeat('-', $length));
	if (-not [String]::IsNullOrEmpty($Title))
	{
		$header = $header.Insert(4, " $Title ");
		if ($header.Length -gt $length) { $header = $header.Substring(0, $length); }
	}

	return $header;
}

function Select-Property
{
	Param(
		[Alias("JPath")]
		[ValidateNotNullOrEmpty()]
		[Parameter(Mandatory)]
		[string]$Path,

		[ValidateNotNull()]
		[Parameter(Mandatory, ValueFromPipeline)]
		$InputObject
	)

	PROCESS
	{
		$result = $InputObject;
		foreach ($propertyName in $Path.Split(@('.', '/', '\')))
		{
			try { $result = $result.$propertyName; }
			catch { return $null; }
		}

		return $result;
	}
}

function Write-Header
{
	Param([string]$Title = "", [int]$Length = 70, [System.ConsoleColor]$Color = [System.ConsoleColor]::DarkGray)
	Write-Host "";
	Out-StringHeader $Title $Length | Write-Host -ForegroundColor $Color;
}

#endregion
