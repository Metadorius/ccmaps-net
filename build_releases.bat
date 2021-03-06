set VER=2.3.1

del CNCMaps_*.zip
del CNCMaps_setup_*.exe
del CNCMaps/bin/*.*
del CNCMaps/obj/*.*
del CNCMaps GUI/obj/*.*
del CNCMaps GUI/obj/*.*

REM MSBUILD=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
set MSBUILD="%PROGRAMFILES(X86)%\MSBuild\14.0\Bin\msbuild.exe"
set MAKENSIS="%PROGRAMFILES(X86)%\nsis\makensis.exe"

%MSBUILD% CNCMaps.sln /p:Configuration=Release
%MAKENSIS% nsisinstaller-rls.nsi

exit

cd CNCMaps/bin/Release
for /D %%f in (*.exe  *.dll NLog.config) DO (
	# zip -r -j ../../../CNCMaps_v%VER%_win.zip "%%f"
)

for /D %%f in (*.exe  *.dll NLog.config OpenTK.dll.config) DO (
	# zip -r -j ../../../CNCMaps_v%VER%_nix.zip "%%f"
)

cd ../../../

%MSBUILD% CNCMaps.sln /p:Configuration=Debug
%MAKENSIS% nsisinstaller-dbg.nsi