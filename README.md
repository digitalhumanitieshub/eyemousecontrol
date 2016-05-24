#EyeMouseControl

##Introduction

EyeMouseControl is a simple system tray app for Windows to turn on and off the EyeXMouse driver for Tobii eye trackers, released under the MIT License (see LICENSE.md). The main reason we developed it was to make it easier for artists to more easily turn on and off control of their mouse with a Tobii EyeX eye tracker. The EyeXMouse open source project (see Credits) provides an easy means to do that, but for people with accessibility needs it can be a little fiddly to switch between eye tracking and a normal mouse. That's largely because it runs in the background and needs to be turned off in the task manager. So, a simple app to streamline EyeXMouse use for artists with disabilities seemed a good idea.

##Using EyeMouseControl

EyeMouseControl is a Microsoft Windows project coded in C# as a .NET app using SharpDevelop. The project provided here can be opened and built directly in SharpDevelop, or Visual Studio if you prefer, without modification (you should even be able to run it using Mono). It is set up as a Release build and requires you to download EyeXMouse, placing the .exe and .dll file in your application folder (e.g. the 'bin/Release' folder, in the project folder with eyexcontrol.exe, after compiling).

You can then double click the eyexcontrol.exe file (or a shortcut you create) to run the application. No forms will appear but you should see an icon with a pair of eyes on your system tray (in the bottom right of the screen, where the clock is). If you can't see it you may have to click the small white pyramid on the system tray where less-used icons appear. Double click the eyes icon to make the control appear or disappear. The button that appears in the control allows you to turn on or off EyeXMouse. If you use eye tracking a lot you may prefer to add our app to your startup items too.

To exit the app, removing it from the system tray, simply right click on the system-tray eyes and select 'Exit'. And, if you accidentally left EyeXMouse turned on then it will be closed before the app closes itself.

##Credits

EyeXMouse is an open source project also on Github: https://github.com/mikethrussell/EyeXMouse

SharpDevelop can be found here: http://www.icsharpcode.net/opensource/sd/

Concept and development: Dr Christopher Creed and Dr Andrew Thomas.

