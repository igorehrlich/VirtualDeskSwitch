# Virtual Desk Switch   ![](https://github.com/igorehrlich/VirtualDeskSwitch/blob/master/pics/app_very_small.png) 

The goal of Virtual Desk Switch is to help you in your daily work with Windows 10 Virtual Desktops. It simplifies switching between virtual desktops and makes the process easier and faster by simply displaying a notification tray icon, that you can click to switch to the next desktop. When you reach the last desktop it simply switches back to the first desktop. Additionally the number of the current desktop is displayed in the notification icon. A right click contextmenu allows you to directly select a virtual desktop from a list.


![Notification Tray Animation](https://github.com/igorehrlich/VirtualDeskSwitch/blob/master/pics/VDeskActionSmall2.gif)

### Features  
  - Switch to next desktop in row, if the notification icon is clicked
  - After last desktop the tool switches back to first desktop, 
  - Right click menu: allows you to select dsktop directly
  - Right click menu: Add/Remove virtual desktops
  - Portable
  - Installer to enable disable Autostart with one click
  - Settings screen
  
> *So why do I need Virtual Desk Switch when there is a native Windows 10 virtual desktop manager in the Task View window?*

The virtual desktops feature of Windows 10 helps me a lot in my daily work, but virtual desktops in Windows 10 are lacking in management functionality. There are at minimum two mouse clicks and some mouse movement needed to simply switch to the next desktop and back. I also found the keyboard shortcuts very uncomfortable to use. I wanted an easy and optimized way to switch between desktops. So I decided to write a tool to simplify and speedup this process. Virtual Desk Switch is my approach to solve this problem in Windows 10. 

### Download

Download the latest stable binary version here: [Binary Version 1.0.0](https://github.com/igorehrlich/VirtualDeskSwitch/releases/download/Release_1.0.0/VirtualDeskSwitch_Release_V1.0.0.zip)
 
### Prerequisites

To run the tool you need:
 - DotNet Framework 4.6.1 or higher
 
 To edit and compile the source code:
 - Visual Studio 2017

### Installing
Virtual Desk Switch is **portable**. You can copy the app folder to any location you like and run VirtualDeskSwitch.exe. There is also an installer/uninstaller built into the settings dialog. The full installer will install the tool in your personal folder and create shortcuts to the Startup menu and on the Desktop. The Autostart feature can be turned on and off in the settings dialog.

Make sure that the notification tray icon is visible. Sometimes Windows hides inactive or new icons. You have to check if the icon is in the hidden area of the notification tray. Just click on the ^Arrow next to the Notification Tray and see if the icon is hidden there. If necessary, just drag the icon with your mouse to the visible area near the clock and drop it there.

![Notification Tray hidden](https://github.com/igorehrlich/VirtualDeskSwitch/blob/master/pics/HiddenIcon.gif)

## Versioning

For the versions available, see the [tags on this repository](https://github.com/igorehrlich/VirtualDeskSwitch/tags). 

## Screenshots
![Direct Select](https://github.com/igorehrlich/VirtualDeskSwitch/blob/master/pics/directSelectAction2.gif)

![Settings](https://github.com/igorehrlich/VirtualDeskSwitch/blob/master/pics/SettingsDialog.png)

![Remove Desktop](https://github.com/igorehrlich/VirtualDeskSwitch/blob/master/pics/removeAction2.gif)

## Author

Igor Ehrlich (C) 2018

## License

This project is licensed under the MIT License - see the \[LICENSE.md\](LICENSE.md) file for details

## Acknowledgments

* Virtual Desk Switch is based on VirtualDesktop, a C# wrapper library by Manato KAMEYA (Grabacr07)
https://github.com/Grabacr07/VirtualDesktop 
Thanks for your hard work to make the Windows 10 Virtual Desktop API usable in C#.
