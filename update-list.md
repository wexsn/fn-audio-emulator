Update List
-------------
* **29.09.2024**:
1. Updated Action file for application assembly, fixed errors. Now SHA256 is output to the release of ready zip files. SHA256 increases trust in the repository, you can view the open source code and action logs and make sure that the application was assembled directly in the repository and published by action bot and compare the SHA256 values ​​in the action and the downloaded file.

* **28.09.2024**:
1. Added a new hotkey "F3" with the "Mute/Unmute" function.
2. Changed the standard volume up and volume down keys.
3. Fixed a bug where the "setkey" command would display an error when specifying any custom key except the letter and numeric keyboard. Now the entire range of "VirtualKey" keys is supported, a separate list of keys has been created, a list with names for each key has been added, "see section #5". It was decided to abandon third-party libraries for stable operation of the program on all existing keyboards and for translating keys.
4. Fixed a bug where the "setkey" command set a custom key over another key.
5. Added a list with the names of each key when specifying a custom key using the "setkey" command, the name of the key will now be displayed, not the "ID" of the virtual key.
6. Changed the standard key delay for faster responsiveness.
7. Optimized the "settings.txt" saving system, added logs.
8. Now the application version is displayed in the "help" section to improve the interface.
9. Now the settings file will be saved to the path "C:\Users\UserName\AppData\Local" to prevent the error of access to the file in the system directory "Failed to save settings: Access to the path 'C:\Windows\system32\settings.txt' is denied.", the settings file "settings.txt" was renamed to a new name "fn-audio-emulator-settings.txt" for quick file search via "Windows Search".
10. Fixed all errors when assembling the application, made some improvements.
11. The application was optimized for ".NET 8", has the ability to add support for "Linux" and "macOS".
Conclusion. Bugs fixed, code optimized. The application was tested, no errors were found. The version is stable for work.

* **10.09.2024**:
1. Added automatic assembly from the program source code using [actions](https://github.com/iwantgirlfriend/fn-audio-emulator/actions). The program will be built through [action on github](https://github.com/iwantgirlfriend/fn-audio-emulator/actions), which adds additional trust to the repository. Now the version of the application will depend on the date and time. For example, "Release 20240910-1830". 2024.09.10 date, 18:30 time.
