@echo off
cls

del /F /Q "%USERPROFILE%\Desktop\VirtualDeskSwitch.lnk" > nul
del /F /Q "%USERPROFILE%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\VirtualDeskSwitch.lnk" > nul

Echo Creating shortcuts...
echo Set oWS = WScript.CreateObject("WScript.Shell") > CreateShortcut.vbs
echo sLinkFile = "%USERPROFILE%\Desktop\VirtualDeskSwitch.lnk" >> CreateShortcut.vbs
echo Set oLink = oWS.CreateShortcut(sLinkFile) >> CreateShortcut.vbs
echo oLink.TargetPath = "%~dp0VirtualDeskSwitch.exe" >> CreateShortcut.vbs
echo oLink.Save >> CreateShortcut.vbs
cscript CreateShortcut.vbs > nul
del CreateShortcut.vbs

echo Set oWS = WScript.CreateObject("WScript.Shell") > CreateShortcut.vbs
echo sLinkFile = "%USERPROFILE%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\VirtualDeskSwitch.lnk" >> CreateShortcut.vbs
echo Set oLink = oWS.CreateShortcut(sLinkFile) >> CreateShortcut.vbs
echo oLink.TargetPath = "%~dp0VirtualDeskSwitch.exe" >> CreateShortcut.vbs
echo oLink.Save >> CreateShortcut.vbs
cscript CreateShortcut.vbs > nul
del CreateShortcut.vbs

echo Done.
rem pause
