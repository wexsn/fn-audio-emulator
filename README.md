FN Audio Emulator | [RU-README Click](https://github.com/iwantgirlfriend/fn-audio-emulator/blob/main/RU-README.md)
================

Quick access "click"
-----------------
1. Update [List](https://github.com/iwantgirlfriend/fn-audio-emulator/blob/main/update-list.md) 
2. [Download](https://github.com/iwantgirlfriend/fn-audio-emulator/releases) from release, compiled with action from open source here on github
3. [Download](https://github.com/iwantgirlfriend/fn-audio-emulator/actions/) from Actions

About the Program
-----------------

FN Audio Emulator is a console program that allows you to emulate the Play/Pause, Next Track, Previous Track, VolumeUp, and VolumeDown keys on keyboards that do not have them. With its help, you can control the playback of audio and video files, regardless of the task you are performing, playing games, or simply reading a book and not wanting to switch to a browser to switch your favorite music playlist.

Emulated Keys
-------------

* **Play/Pause**: allows you to start or stop the playback of an audio or video file "F2"
* **Next Track**: allows you to switch to the next track "F4"
* **Previous Track**: allows you to return to the previous track "F8"
* **Volume Up**: allows you to increase the playback volume "9"
* **Volume Down**: allows you to decrease the playback volume "0"

Screenshot
------------
![FN Audio Emulator](https://raw.githubusercontent.com/iwantgirlfriend/fn-audio-emulator/main/screen.PNG)

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

* Play/Pause: 300 ms
* Next Track: 500 ms
* Previous Track: 500 ms
* Volume Up: 100 ms
* Volume Down: 100 ms


Virtual Key Codes
-----------------

Alphanumeric Keys:

    VK_A - A

    VK_B - B

    VK_C - C

    VK_D - D

    VK_E - E

    VK_F - F

    VK_G - G

    VK_H - H

    VK_I - I

    VK_J - J

    VK_K - K

    VK_L - L

    VK_M - M

    VK_N - N

    VK_O - O

    VK_P - P

    VK_Q - Q

    VK_R - R

    VK_S - S

    VK_T - T

    VK_U - U

    VK_V - V

    VK_W - W

    VK_X - X

    VK_Y - Y

    VK_Z - Z

    VK_0 - 0

    VK_1 - 1

    VK_2 - 2

    VK_3 - 3

    VK_4 - 4

    VK_5 - 5

    VK_6 - 6

    VK_7 - 7

    VK_8 - 8

    VK_9 - 9

Special Keys:

    VK_LBUTTON - Left mouse button

    VK_RBUTTON - Right mouse button

    VK_CANCEL - Control-break processing

    VK_MBUTTON - Middle mouse button (wheel)

    VK_XBUTTON1 - X1 mouse button

    VK_XBUTTON2 - X2 mouse button

    VK_BACK - BACKSPACE

    VK_TAB - TAB

    VK_CLEAR - CLEAR

    VK_RETURN - ENTER

    VK_SHIFT - SHIFT

    VK_CONTROL - CTRL

    VK_MENU - ALT

    VK_PAUSE - PAUSE

    VK_CAPITAL - CAPS LOCK

    VK_KANA - IME Kana mode

    VK_HANGUL - IME Hangul mode

    VK_JUNJA - IME Junja mode

    VK_FINAL - IME final mode

    VK_HANJA - IME Hanja mode

    VK_KANJI - IME Kanji mode

    VK_ESCAPE - ESC

    VK_CONVERT - IME convert

    VK_NONCONVERT - IME nonconvert

    VK_ACCEPT - IME accept

    VK_MODECHANGE - IME mode change request

    VK_SPACE - SPACEBAR

    VK_PRIOR - PAGE UP

    VK_NEXT - PAGE DOWN

    VK_END - END

    VK_HOME - HOME

    VK_LEFT - LEFT ARROW

    VK_UP - UP ARROW

    VK_RIGHT - RIGHT ARROW

    VK_DOWN - DOWN ARROW

    VK_SELECT - SELECT

    VK_PRINT - PRINT

    VK_EXECUTE - EXECUTE

    VK_SNAPSHOT - PRINT SCREEN

    VK_INSERT - INS

    VK_DELETE - DEL

    VK_HELP - HELP

Numeric Keypad:

    VK_NUMPAD0 - Numeric keypad 0

    VK_NUMPAD1 - Numeric keypad 1

    VK_NUMPAD2 - Numeric keypad 2

    VK_NUMPAD3 - Numeric keypad 3

    VK_NUMPAD4 - Numeric keypad 4

    VK_NUMPAD5 - Numeric keypad 5

    VK_NUMPAD6 - Numeric keypad 6

    VK_NUMPAD7 - Numeric keypad 7

    VK_NUMPAD8 - Numeric keypad 8

    VK_NUMPAD9 - Numeric keypad 9

    VK_MULTIPLY - Multiply

    VK_ADD - Add

    VK_SEPARATOR - Separator

    VK_SUBTRACT - Subtract

    VK_DECIMAL - Decimal

    VK_DIVIDE - Divide

Function Keys:

    VK_F1 - F1

    VK_F2 - F2

    VK_F3 - F3

    VK_F4 - F4

    VK_F5 - F5

    VK_F6 - F6

    VK_F7 - F7

    VK_F8 - F8

    VK_F9 - F9

    VK_F10 - F10

    VK_F11 - F11

    VK_F12 - F12

    VK_F13 - F13

    VK_F14 - F14

    VK_F15 - F15

    VK_F16 - F16

    VK_F17 - F17

    VK_F18 - F18

    VK_F19 - F19

    VK_F20 - F20

    VK_F21 - F21

    VK_F22 - F22

    VK_F23 - F23

    VK_F24 - F24

Control Keys:

    VK_NUMLOCK - NUM LOCK

    VK_SCROLL - SCROLL LOCK

    VK_LSHIFT - Left SHIFT

    VK_RSHIFT - Right SHIFT

    VK_LCONTROL - Left CONTROL

    VK_RCONTROL - Right CONTROL

    VK_LMENU - Left ALT

    VK_RMENU - Right ALT

    VK_BROWSER_BACK - Browser Back

    VK_BROWSER_FORWARD - Browser Forward

    VK_BROWSER_REFRESH - Browser Refresh

    VK_BROWSER_STOP - Browser Stop

    VK_BROWSER_SEARCH - Browser Search

    VK_BROWSER_FAVORITES - Browser Favorites

    VK_BROWSER_HOME - Browser Start and Home

    VK_VOLUME_MUTE - Volume Mute

    VK_VOLUME_DOWN - Volume Down

    VK_VOLUME_UP - Volume Up

    VK_MEDIA_NEXT_TRACK - Next Track

    VK_MEDIA_PREV_TRACK - Previous Track

    VK_MEDIA_STOP - Stop Media

    VK_MEDIA_PLAY_PAUSE - Play/Pause Media

    VK_LAUNCH_MAIL - Start Mail

    VK_LAUNCH_MEDIA_SELECT - Select Media

    VK_LAUNCH_APP1 - Start Application 1

    VK_LAUNCH_APP2 - Start Application 2

Symbol Keys:

    VK_OEM_1 - ;:

    VK_OEM_PLUS - =+

    VK_OEM_COMMA - ,<

    VK_OEM_MINUS - -_

    VK_OEM_PERIOD - .>

    VK_OEM_2 - /?

    VK_OEM_3 - `~

    VK_OEM_4 - [{

    VK_OEM_5 - |

    VK_OEM_6 - ]}

    VK_OEM_7 - '"

    VK_OEM_8 - Miscellaneous characters

    VK_OEM_102 - Either the angle bracket key or the backslash key on the RT 102-key keyboard

Japanese Layout Keys:

    VK_PROCESSKEY - IME process key

    VK_ATTN - Attn key

    VK_CRSEL - CrSel key

    VK_EXSEL - ExSel key

    VK_EREOF - Erase EOF

    VK_PLAY - Play key

    VK_ZOOM - Zoom key

    VK_NONAME - Reserved

    VK_PA1 - PA1 key

    VK_OEM_CLEAR - Clear key

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

Copy the code from the downloaded file `Program.cs` and paste it into your new project.

**Step 5: Add dependencies**

Install the dependencies `InputSimulator` and `Spectre.Console` using the NuGet package manager & update "fn-audio-emulator.csproj" file.

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
