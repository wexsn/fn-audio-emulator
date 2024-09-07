FN Audio Emulator
================

About the Program
-----------------

FN Audio Emulator is a console program that allows you to emulate the Play/Pause, Next Track, Previous Track, VolumeUp, and VolumeDown keys on keyboards that do not have them. With its help, you can control the playback of audio and video files, regardless of the task you are performing, playing games, or simply reading a book and not wanting to switch to a browser to switch your favorite music playlist.

Emulated Keys
-------------

* **Play/Pause**: allows you to start or stop the playback of an audio or video file
* **Next Track**: allows you to switch to the next track in the playlist
* **Previous Track**: allows you to return to the previous track in the playlist
* **Volume Up**: allows you to increase the playback volume
* **Volume Down**: allows you to decrease the playback volume

Screenshot
------------
![FN Audio Emulator](https://raw.githubusercontent.com/iwantgirlfriend/fn-audio-emulator/main/screen.PNG)

Advantages
------------

FN Audio Emulator is ideal for users who do not have these keys on their keyboard, or for those who want to have easier access to playback control functions. The program is easy to use and does not require special skills or knowledge.

Open Source Code
----------------

The program has an open source code, any user can build the program themselves or study the code and make changes for themselves, add new features.

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

You can use the following virtual key codes to change keys:

* **Mouse Buttons**
	+ `VK_LBUTTON` (Left mouse button)
	+ `VK_RBUTTON` (Right mouse button)
	+ `VK_MBUTTON` (Middle mouse button)
	+ `VK_XBUTTON1` (X1 mouse button)
	+ `VK_XBUTTON2` (X2 mouse button)
* **Keyboard Keys**
	+ `VK_BACK` (Backspace key)
	+ `VK_TAB` (Tab key)
	+ `VK_CLEAR` (Clear key)
	+ `VK_RETURN` (Enter key)
	+ `VK_SHIFT` (Shift key)
	+ `VK_CONTROL` (Ctrl key)
	+ `VK_MENU` (Alt key)
	+ `VK_PAUSE` (Pause key)
	+ `VK_CAPITAL` (Caps Lock key)
	+ `VK_KANA` (Kana key)
	+ `VK_HANGEUL` (Hangeul key)
	+ `VK_HANGUL` (Hangul key)
	+ `VK_JUNJA` (Junja key)
	+ `VK_FINAL` (Final key)
	+ `VK_HANJA` (Hanja key)
	+ `VK_KANJI` (Kanji key)
	+ `VK_ESCAPE` (Esc key)
	+ `VK_CONVERT` (Convert key)
	+ `VK_NONCONVERT` (Nonconvert key)
	+ `VK_ACCEPT` (Accept key)
	+ `VK_MODECHANGE` (Mode Change key)
	+ `VK_SPACE` (Space key)
	+ `VK_PRIOR` (Page Up key)
	+ `VK_NEXT` (Page Down key)
	+ `VK_END` (End key)
	+ `VK_HOME` (Home key)
	+ `VK_LEFT` (Left arrow key)
	+ `VK_UP` (Up arrow key)
	+ `VK_RIGHT` (Right arrow key)
	+ `VK_DOWN` (Down arrow key)
	+ `VK_SELECT` (Select key)
	+ `VK_PRINT` (Print key)
	+ `VK_EXECUTE` (Execute key)
	+ `VK_SNAPSHOT` (Print Screen key)
	+ `VK_INSERT` (Insert key)
	+ `VK_DELETE` (Delete key)
	+ `VK_HELP` (Help key)
* **Numeric Keypad**
	+ `VK_NUMPAD0` (0 key on numeric keypad)
	+ `VK_NUMPAD1` (1 key on numeric keypad)
	+ `VK_NUMPAD2` (2 key on numeric keypad)
	+ `VK_NUMPAD3` (3 key on numeric keypad)
	+ `VK_NUMPAD4` (4 key on numeric keypad)
	+ `VK_NUMPAD5` (5 key on numeric keypad)
	+ `VK_NUMPAD6` (6 key on numeric keypad)
	+ `VK_NUMPAD7` (7 key on numeric keypad)
	+ `VK_NUMPAD8` (8 key on numeric keypad)
	+ `VK_NUMPAD9` (9 key on numeric keypad)
	+ `VK_MULTIPLY` (Multiply key on numeric keypad)
	+ `VK_ADD` (Add key on numeric keypad)
	+ `VK_SEPARATOR` (Separator key on numeric keypad)
	+ `VK_SUBTRACT` (Subtract key on numeric keypad)
	+ `VK_DECIMAL` (Decimal key on numeric keypad)
	+ `VK_DIVIDE` (Divide key on numeric keypad)
* **Function Keys**
	+ `VK_F1` (F1 key)
	+ `VK_F2` (F2 key)
	+ `VK_F3` (F3 key)
	+ `VK_F4` (F4 key)
	+ `VK_F5` (F5 key)
	+ `VK_F6` (F6 key)
	+ `VK_F7` (F7 key)
	+ `VK_F8` (F8 key)
	+ `VK_F9` (F9 key)
	+ `VK_F10` (F10 key)
	+ `VK_F11` (F11 key)
	+ `VK_F12` (F12 key)
	+ `VK_F13` (F13 key)
	+ `VK_F14` (F14 key)
	+ `VK_F15` (F15 key)
	+ `VK_F16` (F16 key)
	+ `VK_F17` (F17 key)
	+ `VK_F18` (F18 key)
	+ `VK_F19` (F19 key)
	+ `VK_F20` (F20 key)
	+ `VK_F21` (F21 key)
	+ `VK_F22` (F22 key)
	+ `VK_F23` (F23 key)
	+ `VK_F24` (F24 key)
* **Letter Keys**
	+ `VK_A` (A key)
	+ `VK_B` (B key)
	+ `VK_C` (C key)
	+ `VK_D` (D key)
	+ `VK_E` (E key)
	+ `VK_F` (F key)
	+ `VK_G` (G key)
	+ `VK_H` (H key)
	+ `VK_I` (I key)
	+ `VK_J` (J key)
	+ `VK_K` (K key)
	+ `VK_L` (L key)
	+ `VK_M` (M key)
	+ `VK_N` (N key)
	+ `VK_O` (O key)
	+ `VK_P` (P key)
	+ `VK_Q` (Q key)
	+ `VK_R` (R key)
	+ `VK_S` (S key)
	+ `VK_T` (T key)
	+ `VK_U` (U key)
	+ `VK_V` (V key)
	+ `VK_W` (W key)
	+ `VK_X` (X key)
	+ `VK_Y` (Y key)
	+ `VK_Z` (Z key)
* **Special Keys**
	+ `VK_LWIN` (Left Windows key)
	+ `VK_RWIN` (Right Windows key)
	+ `VK_APPS` (Applications key)
	+ `VK_SLEEP` (Sleep key)

Building the Project (Optional)
------------------------------

To build the project, follow these steps:

**Step 1: Install the necessary tools**

Install Visual Studio or Visual Studio Code on your computer. Install .NET Core SDK on your computer.

**Step 2: Clone the repository**

Download the source code from the project page.

**Step 3: Create a new C# project**

Create a new project in Visual Studio or Visual Studio Code. Choose "Console App (.NET Core)" as the project type.

**Step 4: Copy the code**

Copy the code from the downloaded file `Program.cs` and paste it into your new project.

**Step 5: Add dependencies**

Install the dependencies `InputSimulator` and `Spectre.Console` using the NuGet package manager & update "fn-audio-emulator.csproj" file.

**Step 6: Build the EXE file**

Press `Ctrl + B` to build the project. The EXE file will be created in the `bin/Debug` folder.

**Step 7: You're done!**

You can now use the FN-Audio-Emulator with open source code and enjoy easy music switching.

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
