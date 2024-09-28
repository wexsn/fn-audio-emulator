FN Audio Emulator | [RU-README Click](https://github.com/iwantgirlfriend/fn-audio-emulator/blob/main/RU-README.md)
================

Quick access "click"
-----------------
1. Update [List](https://github.com/iwantgirlfriend/fn-audio-emulator/blob/main/update-list.md) 
2. [Download](https://github.com/iwantgirlfriend/fn-audio-emulator/releases) from release, compiled with action from open source here on github
3. [Download](https://github.com/iwantgirlfriend/fn-audio-emulator/actions/) from Actions

About the Program
-----------------

FN Audio Emulator is a console program that allows you to emulate the Play/Pause, Next Track, Previous Track, Mute/Unmute, VolumeUp and VolumeDown keys on keyboards that do not have them. With its help, you can control the playback of audio and video files, regardless of the task you are performing, playing games, or simply reading a book and not wanting to switch to a browser to switch your favorite music playlist.

Emulated Keys
-------------

* **Play/Pause "F2"**: allows you to start or stop the playback of an audio or video file
* **Next Track "F4"**: allows you to switch to the next track
* **Previous Track "F8"**: allows you to return to the previous track
* **Hide/Show Console "F12"** Hide/Show Console
* **Mute/Unmute "F3"**: Enable/disable sound in system
* **Volume Up "+"**: allows you to increase the playback volume
* **Volume Down "-"**: allows you to decrease the playback volume

Screenshot
------------
![FN Audio Emulator](https://raw.githubusercontent.com/iwantgirlfriend/fn-audio-emulator/refs/heads/main/.github/20240928update.PNG)

Advantages
------------

FN Audio Emulator is ideal for users who do not have these keys on their keyboard, or for those who want to have easier access to playback control functions. The program is easy to use and does not require special skills or knowledge.

Open Source Code
----------------

The program has an open source code, any user can build the program themselves or study the code and make changes for themselves, add new features. Just don't change the links to the official repository and the name of the program. With the new update, the program is built via action automatically with any change in the code.

Settings
------------

You can adjust the key delay or change the hotkeys to any other one, as you like.

Commands
--------

The program supports the following commands:

* `autostart`: Enable the application to start automatically when the system boots.
* `offauto`: Disable the application from starting automatically.
* `clear`: Clear the console.
* `setkey`: Set a custom key.
	+ `<type>` can be: `pauseplay`, `nexttrack`, `previoustrack`, `volumeup`, `volumedown`, `toggleconsole`.
	+ `<key>` — the name of the key from the VirtualKeyCode enumeration.
	+ Example: `setkey pauseplay VK_1`.
* `setdelay`: Set the key delay in milliseconds.
	+ `<type>` can be: `pauseplay`, `nexttrack`, `previoustrack`, `volumeup`, `volumedown`, `toggleconsole`.
	+ `<delay>` — the delay in milliseconds.
	+ Example: `setdelay pauseplay 300`.
* `showkeys`: Show the current key settings.
* `russian`: Switch the interface to Russian.
* `english`: Switch the interface to English.
* `exit`: Exit the application.

Default Key Delay
-----------------

By default, the program uses the following delays for keys (it is not recommended to reduce the delay to avoid errors):

* Play/Pause: 250 ms
* Next Track: 300 ms
* Previous Track: 300 ms
* Hide/Show Console: 0 ms
* Mute/Unmute: 250 ms
* Volume Up: 100 ms
* Volume Down: 100 ms


Virtual Key Codes
-----------------

Alphanumeric Keys:

- **VK_LBUTTON** - Left Mouse Button
- **VK_RBUTTON** - Right Mouse Button
- **VK_CANCEL** - Cancel
- **VK_MBUTTON** - Middle Mouse Button
- **VK_XBUTTON1** - X1 Mouse Button
- **VK_XBUTTON2** - X2 Mouse Button
- **VK_BACK** - Backspace
- **VK_TAB** - Tab
- **VK_CLEAR** - Clear
- **VK_RETURN** - Enter
- **VK_SHIFT** - Shift
- **VK_CONTROL** - Ctrl
- **VK_MENU** - Alt
- **VK_PAUSE** - Pause
- **VK_CAPITAL** - Caps Lock
- **VK_KANA** - Kana
- **VK_HANGUL** - Hangul
- **VK_JUNJA** - Junja
- **VK_FINAL** - Final
- **VK_HANJA** - Hanja
- **VK_KANJI** - Kanji
- **VK_ESCAPE** - Esc
- **VK_CONVERT** - Convert
- **VK_NONCONVERT** - NonConvert
- **VK_ACCEPT** - Accept
- **VK_MODECHANGE** - Mode Change
- **VK_SPACE** - Space
- **VK_PRIOR** - Page Up
- **VK_NEXT** - Page Down
- **VK_END** - End
- **VK_HOME** - Home
- **VK_LEFT** - Left Arrow
- **VK_UP** - Up Arrow
- **VK_RIGHT** - Right Arrow
- **VK_DOWN** - Down Arrow
- **VK_SELECT** - Select
- **VK_PRINT** - Print
- **VK_EXECUTE** - Execute
- **VK_SNAPSHOT** - Print Screen
- **VK_INSERT** - Insert
- **VK_DELETE** - Delete
- **VK_HELP** - Help
- **VK_0** - 0
- **VK_1** - 1
- **VK_2** - 2
- **VK_3** - 3
- **VK_4** - 4
- **VK_5** - 5
- **VK_6** - 6
- **VK_7** - 7
- **VK_8** - 8
- **VK_9** - 9
- **VK_A** - A
- **VK_B** - B
- **VK_C** - C
- **VK_D** - D
- **VK_E** - E
- **VK_F** - F
- **VK_G** - G
- **VK_H** - H
- **VK_I** - I
- **VK_J** - J
- **VK_K** - K
- **VK_L** - L
- **VK_M** - M
- **VK_N** - N
- **VK_O** - O
- **VK_P** - P
- **VK_Q** - Q
- **VK_R** - R
- **VK_S** - S
- **VK_T** - T
- **VK_U** - U
- **VK_V** - V
- **VK_W** - W
- **VK_X** - X
- **VK_Y** - Y
- **VK_Z** - Z
- **VK_LWIN** - Left Windows
- **VK_RWIN** - Right Windows
- **VK_APPS** - Applications
- **VK_SLEEP** - Sleep
- **VK_NUMPAD0** - Num 0
- **VK_NUMPAD1** - Num 1
- **VK_NUMPAD2** - Num 2
- **VK_NUMPAD3** - Num 3
- **VK_NUMPAD4** - Num 4
- **VK_NUMPAD5** - Num 5
- **VK_NUMPAD6** - Num 6
- **VK_NUMPAD7** - Num 7
- **VK_NUMPAD8** - Num 8
- **VK_NUMPAD9** - Num 9
- **VK_MULTIPLY** - Num *
- **VK_ADD** - Num +
- **VK_SEPARATOR** - Separator
- **VK_SUBTRACT** - Num -
- **VK_DECIMAL** - Num .
- **VK_DIVIDE** - Num /
- **VK_F1** - F1
- **VK_F2** - F2
- **VK_F3** - F3
- **VK_F4** - F4
- **VK_F5** - F5
- **VK_F6** - F6
- **VK_F7** - F7
- **VK_F8** - F8
- **VK_F9** - F9
- **VK_F10** - F10
- **VK_F11** - F11
- **VK_F12** - F12
- **VK_F13** - F13
- **VK_F14** - F14
- **VK_F15** - F15
- **VK_F16** - F16
- **VK_F17** - F17
- **VK_F18** - F18
- **VK_F19** - F19
- **VK_F20** - F20
- **VK_F21** - F21
- **VK_F22** - F22
- **VK_F23** - F23
- **VK_F24** - F24
- **VK_NUMLOCK** - Num Lock
- **VK_SCROLL** - Scroll Lock
- **VK_LSHIFT** - Left Shift
- **VK_RSHIFT** - Right Shift
- **VK_LCONTROL** - Left Ctrl
- **VK_RCONTROL** - Right Ctrl
- **VK_LMENU** - Left Alt
- **VK_RMENU** - Right Alt
- **VK_BROWSER_BACK** - Browser Back
- **VK_BROWSER_FORWARD** - Browser Forward
- **VK_BROWSER_REFRESH** - Browser Refresh
- **VK_BROWSER_STOP** - Browser Stop
- **VK_BROWSER_SEARCH** - Browser Search
- **VK_BROWSER_FAVORITES** - Browser Favorites
- **VK_BROWSER_HOME** - Browser Home
- **VK_VOLUME_MUTE** - Volume Mute
- **VK_VOLUME_DOWN** - Volume Down
- **VK_VOLUME_UP** - Volume Up
- **VK_MEDIA_NEXT_TRACK** - Next Track
- **VK_MEDIA_PREV_TRACK** - Previous Track
- **VK_MEDIA_STOP** - Media Stop
- **VK_MEDIA_PLAY_PAUSE** - Play/Pause
- **VK_LAUNCH_MAIL** - Launch Mail
- **VK_LAUNCH_MEDIA_SELECT** - Select Media
- **VK_LAUNCH_APP1** - Launch App1
- **VK_LAUNCH_APP2** - Launch App2
- **VK_OEM_1** - OEM 1
- **VK_OEM_PLUS** - +
- **VK_OEM_COMMA** - ,
- **VK_OEM_MINUS** - -
- **VK_OEM_PERIOD** - .
- **VK_OEM_2** - OEM 2
- **VK_OEM_3** - OEM 3
- **VK_OEM_4** - OEM 4
- **VK_OEM_5** - OEM 5
- **VK_OEM_6** - OEM 6
- **VK_OEM_7** - OEM 7
- **VK_OEM_8** - OEM 8
- **VK_OEM_102** - OEM 102
- **VK_PROCESSKEY** - Process Key
- **VK_PACKET** - Packet
- **VK_ATTN** - Attn
- **VK_CRSEL** - CrSel
- **VK_EXSEL** - ExSel
- **VK_EREOF** - Erase EOF
- **VK_PLAY** - Play
- **VK_ZOOM** - Zoom
- **VK_NONAME** - No Name
- **VK_PA1** - PA1
- **VK_OEM_CLEAR** - Clear

This list covers most of the common VirtualKeyCode constants used in Windows applications. For a complete list, you can refer to the official Microsoft documentation or use API functions like GetKeyNameText to get the textual representation of a key by its code.

Building the Project (Optional)
------------------------------

To build the project, follow these steps:

**Step 1: Install the necessary tools**

Install Visual Studio on your computer. Install .NET Core SDK on your computer.

**Step 2: Clone the repository**

Download the source code from the project page.

**Step 3: Create a new C# project**

Create a new project in Visual Studio. Choose "Console App (.NET Core)" as the project type.

**Step 4: Copy the code**

Copy the code from the downloaded file `Program.cs` and `virtualkeysdlc.cs` and paste it into your new project.

**Step 5: Add dependencies**

Install the dependencies `InputSimulatorEx` and `Spectre.Console` using the NuGet package manager & update "fn-audio-emulator.csproj" file.

**Step 6: Build the EXE file**

Press `Ctrl + B` to build the project. The EXE file will be created in the `bin/Debug` folder.

**Step 7: You're done!**

You can now use the FN-Audio-Emulator with open source code and enjoy easy music switching. With the new update, the program is built via action automatically with any change in the code.

Community and Support
------------------------

If you have any suggestions or questions, don't hesitate to create an issue or pull request.

The program will receive updates for a long time, and we'll be happy to see your activity in the community.

**Creating an issue**

If you found a bug or want to suggest a new feature, create an issue on our GitHub page. We'll be happy to consider your proposal and answer your questions.

**Pull request**

If you want to make changes to the program, create a pull request on our GitHub page. We'll be happy to consider your changes and include them in the program.

**Feedback**

We're always happy to hear from you and ready to help. If you have any questions or suggestions, don't hesitate to contact us.

Thank you for your support!
