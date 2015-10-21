@ECHO OFF
setlocal

REM initialization
set NUGET_EXE=..\packages\Nuget.Commandline.2.8.6\tools\nuget.exe

REM appveyor
if not "%APPVEYOR_BUILD_VERSION%" == "" set BUILD_VERSION=%APPVEYOR_BUILD_VERSION%

REM checks
if "%BUILD_VERSION%" == "" echo Missing BUILD_VERSION & goto :END

if "%1" == "--after-build" goto :SKIP_BUILD

echo.
if "%1" == "--no-msbuild" goto :SKIP_BUILD
call .\build.cmd & if errorlevel 1 goto :END
shift

:SKIP_BUILD

REM Create Nuget Package
%NUGET_EXE% pack DataUri.nuspec -verbose -version %BUILD_VERSION%

if not "%1" == "--no-deploy" %NUGET_EXE% 
shift

:END
popd
