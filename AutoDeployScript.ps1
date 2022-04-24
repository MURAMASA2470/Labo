$workDir = pwd
$projectName = "ASP.NET_Sample"
$iisPath = "C:\inetpub\wwwroot"

git clone "https://github.com/MURAMASA2470/${projectName}.git"

cd ".\${projectName}"

git checkout develop

cd "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\"
.\msbuild.exe "${workDir}\${projectName}\WebApplication1.sln" /p:DeployOnBuild=true /p:PublishProfile=FolderProfile /p:Configuration=Release /p:Platform="Any CPU"
cd "${workDir}\${projectName}\WebApplication1"

mkdir -p "${iisPath}\WebApp\"
xcopy /S /I ".\www" "${iisPath}\WebApp\"

cd ${workDir}
