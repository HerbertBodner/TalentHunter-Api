function Exec
{
    [CmdletBinding()]
    param(
        [Parameter(Position=0,Mandatory=1)][scriptblock]$cmd,
        [Parameter(Position=1,Mandatory=0)][string]$errorMessage = ($msgs.error_bad_command -f $cmd)
    )
    echo "Exec: $cmd"
    & $cmd
    if ($lastexitcode -ne 0) {
        throw ("Exec: " + $errorMessage)
    }
}

$solution_name="WaCore.TalentHunter.sln"

echo "Restore packages"
exec { & dotnet restore .\src\$solution_name }

Push-Location .\src
    $publish_path = "./bin/Release/netcoreapp2.0/publish/"
    echo "Publish to: $publish_path"
    dotnet publish -c release .\$solution_name -o $publish_path

    # specify build path from dockerfile point-of-view (not from docker-compose.yml point-of-view)
    docker-compose build --build-arg "source=$publish_path" wacore.talenthunter.api
Pop-Location