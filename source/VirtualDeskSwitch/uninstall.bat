@echo off
cls
echo Stopping VirtualDeskSwitch instances...
rem stop VirtualDeskSwitch.exe process and sleep 4 seconds (ping)
tasklist /FI "IMAGENAME eq VirtualDeskSwitch.exe" 2>NUL | find /I /N "VirtualDeskSwitch.exe">NUL
if "%ERRORLEVEL%"=="0" taskkill /f /im VirtualDeskSwitch.exe & ping 127.0.0.1 -n 6 > nul

Echo Deleting files...
del /F /Q "%USERPROFILE%\VirtualDeskSwitch"\*.* > nul
del /F /Q "%USERPROFILE%\Desktop\VirtualDeskSwitch.lnk" > nul
del /F /Q "%USERPROFILE%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\VirtualDeskSwitch.lnk" > nul
del /F /Q "%USERPROFILE%\VirtualDeskSwitch" > nul
echo Done.
pause
