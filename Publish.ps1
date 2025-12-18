<#
.SYNOPSIS
    Publishes the Highlight.Api package to NuGet.org

.DESCRIPTION
    This script performs the following steps:
    1. Checks for uncommitted changes (git porcelain)
    2. Determines the Nerdbank git version
    3. Validates nuget-key.txt exists, has content, and is gitignored
    4. Runs unit tests (unless -SkipTests is specified)
    5. Publishes to nuget.org

.PARAMETER SkipTests
    If specified, skips running unit tests

.EXAMPLE
    .\Publish.ps1
    .\Publish.ps1 -SkipTests
#>

param(
    [switch]$SkipTests
)

$ErrorActionPreference = 'Stop'

# Step 1: Check for uncommitted changes (git porcelain)
Write-Host "Checking for uncommitted changes..." -ForegroundColor Cyan
$gitStatus = git status --porcelain
if ($gitStatus) {
    Write-Error "ERROR: There are uncommitted changes in the repository. Please commit or stash them before publishing."
    exit 1
}
Write-Host "No uncommitted changes detected." -ForegroundColor Green

# Step 2: Determine the Nerdbank git version
Write-Host "Determining Nerdbank git version..." -ForegroundColor Cyan
$version = nbgv get-version -v NuGetPackageVersion
if ($LASTEXITCODE -ne 0) {
    Write-Error "ERROR: Failed to determine Nerdbank git version. Ensure nbgv is installed (dotnet tool install -g nbgv)."
    exit 1
}
Write-Host "Version: $version" -ForegroundColor Green

# Step 3: Check that nuget-key.txt exists, has content, and is gitignored
Write-Host "Validating nuget-key.txt..." -ForegroundColor Cyan
$nugetKeyPath = Join-Path $PSScriptRoot "nuget-key.txt"

if (-not (Test-Path $nugetKeyPath)) {
    Write-Error "ERROR: nuget-key.txt does not exist in the solution root."
    exit 1
}

$nugetKey = (Get-Content $nugetKeyPath -Raw).Trim()
if ([string]::IsNullOrWhiteSpace($nugetKey)) {
    Write-Error "ERROR: nuget-key.txt is empty."
    exit 1
}

# Check if nuget-key.txt is gitignored
$gitCheck = git check-ignore -q "nuget-key.txt" 2>&1
if ($LASTEXITCODE -ne 0) {
    Write-Error "ERROR: nuget-key.txt is not in .gitignore. This is a security risk."
    exit 1
}
Write-Host "nuget-key.txt validated and is gitignored." -ForegroundColor Green

# Step 4: Run unit tests (unless -SkipTests is specified)
if (-not $SkipTests) {
    Write-Host "Running unit tests..." -ForegroundColor Cyan
    dotnet test "$PSScriptRoot\Highlight.Api.Test\Highlight.Api.Test.csproj" --configuration Release --no-restore
    if ($LASTEXITCODE -ne 0) {
        Write-Error "ERROR: Unit tests failed."
        exit 1
    }
    Write-Host "Unit tests passed." -ForegroundColor Green
} else {
    Write-Host "Skipping unit tests as requested." -ForegroundColor Yellow
}

# Step 5: Build and publish to nuget.org
Write-Host "Building package..." -ForegroundColor Cyan
dotnet build "$PSScriptRoot\Highlight.Api\Highlight.Api.csproj" --configuration Release
if ($LASTEXITCODE -ne 0) {
    Write-Error "ERROR: Build failed."
    exit 1
}

$packagePath = Join-Path $PSScriptRoot "Highlight.Api\bin\Release\Highlight.Api.$version.nupkg"
if (-not (Test-Path $packagePath)) {
    Write-Error "ERROR: Package not found at expected path: $packagePath"
    exit 1
}

Write-Host "Publishing to nuget.org..." -ForegroundColor Cyan
dotnet nuget push $packagePath --api-key $nugetKey --source https://api.nuget.org/v3/index.json --skip-duplicate
if ($LASTEXITCODE -ne 0) {
    Write-Error "ERROR: Failed to publish to nuget.org."
    exit 1
}

Write-Host "Successfully published Highlight.Api version $version to nuget.org!" -ForegroundColor Green
exit 0
