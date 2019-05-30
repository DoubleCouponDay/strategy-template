$ErrorActionPreference = 'stop'
$previousdirectory = (Get-Item -Path './').FullName
Write-Host "projects will pack to current directory $previousdirectory"
$versionnum = Read-Host -Prompt 'enter version number'

if($versionnum -eq '')
{
    Write-Host 'using default version number.'
    $versionnum = '1.0.0'
}

else
{
    Write-Host "using version number $versionnum"
}

$projectfolder = Read-Host -Prompt 'enter project folder to pack (must contain a single .proj file)'

if($projectfolder -eq '')
{
    Write-Host 'project folder not specified. closing...'
    Exit
}

$notdirectoryerror = 'given path is not a directory'

Try
{
    if((Get-Item $projectfolder) -isnot [System.IO.DirectoryInfo]) #getting item of a scrambled string can fail
    {
	    Write-Host $notdirectoryerror
	    Exit
    }
}

Catch
{
    Write-Host $notdirectoryerror
    Exit
}

$quietverbosity = 'quiet'
cd $projectfolder
nuget spec -Verbosity $quietverbosity
cd $previousdirectory
Write-Host '##################################################'
Write-Host 'Add .nuspec folder to solution. Fill in authors, description. Remove tags.'
Write-Host '##################################################'
Pause
nuget pack $projectfolder -Build -Verbosity $quietverbosity -Version $versionnum `
    -Properties Configuration=Release `
    -OutputDirectory $previousdirectory