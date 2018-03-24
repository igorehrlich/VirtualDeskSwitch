@echo off
cls
echo Stopping VirtualDeskSwitch instances...
rem stop VirtualDeskSwitch.exe process and sleep 4 seconds (ping)
tasklist /FI "IMAGENAME eq VirtualDeskSwitch.exe" 2>NUL | find /I /N "VirtualDeskSwitch.exe">NUL
if "%ERRORLEVEL%"=="0" taskkill /f /im VirtualDeskSwitch.exe & ping 127.0.0.1 -n 6 > nul

Echo Copying files...
if not exist "%USERPROFILE%\VirtualDeskSwitch" mkdir "%USERPROFILE%\VirtualDeskSwitch"
xcopy /E /Q /Y *.* "%USERPROFILE%\VirtualDeskSwitch\"*.*

echo Removing old shortcuts
del /F /Q "%USERPROFILE%\Desktop\VirtualDeskSwitch.lnk" > nul
del /F /Q "%USERPROFILE%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\VirtualDeskSwitch.lnk" > nul

Echo Creating shortcuts...
echo Set oWS = WScript.CreateObject("WScript.Shell") > CreateShortcut.vbs
echo sLinkFile = "%USERPROFILE%\Desktop\VirtualDeskSwitch.lnk" >> CreateShortcut.vbs
echo Set oLink = oWS.CreateShortcut(sLinkFile) >> CreateShortcut.vbs
echo oLink.TargetPath = "%USERPROFILE%\VirtualDeskSwitch\VirtualDeskSwitch.exe" >> CreateShortcut.vbs
echo oLink.Save >> CreateShortcut.vbs
cscript CreateShortcut.vbs > nul
del CreateShortcut.vbs

echo Set oWS = WScript.CreateObject("WScript.Shell") > CreateShortcut.vbs
echo sLinkFile = "%USERPROFILE%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\VirtualDeskSwitch.lnk" >> CreateShortcut.vbs
echo Set oLink = oWS.CreateShortcut(sLinkFile) >> CreateShortcut.vbs
echo oLink.TargetPath = "%USERPROFILE%\VirtualDeskSwitch\VirtualDeskSwitch.exe" >> CreateShortcut.vbs
echo oLink.Save >> CreateShortcut.vbs
cscript CreateShortcut.vbs > nul
del CreateShortcut.vbs

echo Starting VirtuaDeskSwitch...
start "VirtualDeskSwitch" "%USERPROFILE%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\VirtualDeskSwitch.lnk"
echo Done.
pause
