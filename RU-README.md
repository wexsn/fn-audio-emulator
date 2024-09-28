FN Audio Emulator
================

Быстрый доступ "нажми"
-----------------
1. Список [обновлений](https://github.com/iwantgirlfriend/fn-audio-emulator/blob/main/update-list.md) 
2. [Скачать](https://github.com/iwantgirlfriend/fn-audio-emulator/releases) из release, собрано с помощью action из открытого исходного кода здесь на Github
3. [Скачать](https://github.com/iwantgirlfriend/fn-audio-emulator/actions/) из Actions

О программе
------------

FN Audio Emulator - это консольная программа, которая позволяет эмулировать клавиши Play/Pause, Next Track, Previous Track, Mute/Unmute VolumeUp, VolumeDown на клавиатурах, где они отсутствуют. С ее помощью вы можете управлять воспроизведением аудио и видео файлов, не зависимо от того, какую задачу вы выполняете, играете или просто читаете книгу и вам не хочется сворачиваться в браузер, чтобы переключить ваш любимый плейлист музыки.

Эмулируемые клавиши
--------------------

* **Play/Pause "F2"**: позволяет начать или остановить воспроизведение аудио или видео файла "F2"
* **Next Track "F4"**: позволяет перейти к следующему треку "F4"
* **Previous Track "F8"**: позволяет вернуться к предыдущему треку "F8"
* **Hide/Show Console "F12"**: Скрыть/Показать консоль
* **Mute/Unmute "F3"**: позволяет выключить/включить звук в системе
* **Увеличение громкости "+"**: позволяет увеличить громкость воспроизведения "9"
* **Уменьшение громкости "-"**: позволяет уменьшить громкость воспроизведения "0"

Screenshot
------------
![FN Audio Emulator](https://raw.githubusercontent.com/iwantgirlfriend/fn-audio-emulator/refs/heads/main/.github/20240928ru-update.PNG)

Преимущества
-------------

FN Audio Emulator идеально подходит для пользователей, у которых клавиатура не имеет этих клавиш, или для тех, кто хочет иметь более удобный доступ к функциям управления воспроизведением. Программа проста в использовании и не требует специальных навыков или знаний.

Открытый исходный код
--------------------

Программа имеет открытый исходный код, любой пользователь может собрать программу самостоятельно или изучить код и внести изменения для себя, добавить новые возможности. Только не меняйте ссылки на официальный репозиторий и название программы. С новым обновлением программа собирается через actions автоматически при любом изменении кода.

Настройки
------------

Вы можете настроить задержку клавиш или изменить горячие клавиши на любую другую, как вам удобно.

Команды
--------

Программа поддерживает следующие команды:

* `autostart`: Включить автозапуск приложения при загрузке системы.
* `offauto`: Отключить автозапуск приложения.
* `clear`: Очистить консоль.
* `setkey`: Установить пользовательскую клавишу.
	+ `<type>` может быть: `pauseplay`, `nexttrack`, `previoustrack`, `volumeup`, `volumedown`, `toggleconsole`.
	+ `<key>` — название клавиши из перечисления VirtualKeyCode.
	+ Пример: `setkey pauseplay VK_1`.
* `setdelay`: Установить задержку клавиши в миллисекундах.
	+ `<type>` может быть: `pauseplay`, `nexttrack`, `previoustrack`, `volumeup`, `volumedown`, `toggleconsole`.
	+ `<delay>` — задержка в миллисекундах.
	+ Пример: `setdelay pauseplay 300`.
* `showkeys`: Показать текущие настройки клавиш.
* `russian`: Переключить интерфейс на русский язык.
* `english`: Переключить интерфейс на английский язык.
* `exit`: Выйти из приложения.

Стандартная задержка клавиш
---------------------------

По умолчанию программа использует следующие задержки для клавиш (не рекомендуется уменшать задежку, чтобы не было ошибок):

* Пауза/Воспроизведение: 250 мс
* Следующий трек: 300 мс
* Предыдущий трек: 300 мс
* Выключить/включить звук: 250 мс
* Скрыть/показать консоль: 0 мс
* Увеличение громкости: 100 мс
* Уменьшение громкости: 100 мс

Список виртуальных клавиш
-------------------------

Вы можете использовать следующие виртуальные клавиши для изменения клавиш:

Алфавитно-цифровые клавиши:

VK_LBUTTON - Left Mouse Button
VK_RBUTTON - Right Mouse Button
VK_CANCEL - Cancel
VK_MBUTTON - Middle Mouse Button
VK_XBUTTON1 - X1 Mouse Button
VK_XBUTTON2 - X2 Mouse Button
VK_BACK - Backspace
VK_TAB - Tab
VK_CLEAR - Clear
VK_RETURN - Enter
VK_SHIFT - Shift
VK_CONTROL - Ctrl
VK_MENU - Alt
VK_PAUSE - Pause
VK_CAPITAL - Caps Lock
VK_KANA - Kana
VK_HANGUL - Hangul
VK_JUNJA - Junja
VK_FINAL - Final
VK_HANJA - Hanja
VK_KANJI - Kanji
VK_ESCAPE - Esc
VK_CONVERT - Convert
VK_NONCONVERT - NonConvert
VK_ACCEPT - Accept
VK_MODECHANGE - Mode Change
VK_SPACE - Space
VK_PRIOR - Page Up
VK_NEXT - Page Down
VK_END - End
VK_HOME - Home
VK_LEFT - Left Arrow
VK_UP - Up Arrow
VK_RIGHT - Right Arrow
VK_DOWN - Down Arrow
VK_SELECT - Select
VK_PRINT - Print
VK_EXECUTE - Execute
VK_SNAPSHOT - Print Screen
VK_INSERT - Insert
VK_DELETE - Delete
VK_HELP - Help
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
VK_LWIN - Left Windows
VK_RWIN - Right Windows
VK_APPS - Applications
VK_SLEEP - Sleep
VK_NUMPAD0 - Num 0
VK_NUMPAD1 - Num 1
VK_NUMPAD2 - Num 2
VK_NUMPAD3 - Num 3
VK_NUMPAD4 - Num 4
VK_NUMPAD5 - Num 5
VK_NUMPAD6 - Num 6
VK_NUMPAD7 - Num 7
VK_NUMPAD8 - Num 8
VK_NUMPAD9 - Num 9
VK_MULTIPLY - Num *
VK_ADD - Num +
VK_SEPARATOR - Separator
VK_SUBTRACT - Num -
VK_DECIMAL - Num .
VK_DIVIDE - Num /
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
VK_NUMLOCK - Num Lock
VK_SCROLL - Scroll Lock
VK_LSHIFT - Left Shift
VK_RSHIFT - Right Shift
VK_LCONTROL - Left Ctrl
VK_RCONTROL - Right Ctrl
VK_LMENU - Left Alt
VK_RMENU - Right Alt
VK_BROWSER_BACK - Browser Back
VK_BROWSER_FORWARD - Browser Forward
VK_BROWSER_REFRESH - Browser Refresh
VK_BROWSER_STOP - Browser Stop
VK_BROWSER_SEARCH - Browser Search
VK_BROWSER_FAVORITES - Browser Favorites
VK_BROWSER_HOME - Browser Home
VK_VOLUME_MUTE - Volume Mute
VK_VOLUME_DOWN - Volume Down
VK_VOLUME_UP - Volume Up
VK_MEDIA_NEXT_TRACK - Next Track
VK_MEDIA_PREV_TRACK - Previous Track
VK_MEDIA_STOP - Media Stop
VK_MEDIA_PLAY_PAUSE - Play/Pause
VK_LAUNCH_MAIL - Launch Mail
VK_LAUNCH_MEDIA_SELECT - Select Media
VK_LAUNCH_APP1 - Launch App1
VK_LAUNCH_APP2 - Launch App2
VK_OEM_1 - OEM 1
VK_OEM_PLUS - +
VK_OEM_COMMA - ,
VK_OEM_MINUS - -
VK_OEM_PERIOD - .
VK_OEM_2 - OEM 2
VK_OEM_3 - OEM 3
VK_OEM_4 - OEM 4
VK_OEM_5 - OEM 5
VK_OEM_6 - OEM 6
VK_OEM_7 - OEM 7
VK_OEM_8 - OEM 8
VK_OEM_102 - OEM 102
VK_PROCESSKEY - Process Key
VK_PACKET - Packet
VK_ATTN - Attn
VK_CRSEL - CrSel
VK_EXSEL - ExSel
VK_EREOF - Erase EOF
VK_PLAY - Play
VK_ZOOM - Zoom
VK_NONAME - No Name
VK_PA1 - PA1
VK_OEM_CLEAR - Clear

Этот список не является исчерпывающим, но охватывает большинство распространенных клавиш. Для полного списка можно обратиться к официальной документации Microsoft или использовать функции API, такие как GetKeyNameText, чтобы получить текстовое представление клавиши по её коду.

Сборка проекта (необязательно)
-----------------------------

Чтобы собрать проект, выполните следующие шаги:

**Шаг 1. Установите необходимые инструменты**

Установите Visual Studio на свой компьютер. Установите .NET Core SDK на свой компьютер.

**Шаг 2. Клонируйте репозиторий**

Загрузите исходный код со страницы проекта.

**Шаг 3. Создайте новый проект C#**

Создайте новый проект в Visual Studio. Выберите «Console App (.NET Core)» в качестве типа проекта.

**Шаг 4. Скопируйте код**

Скопируйте код из загруженного файла `Program.cs`, `virtualkeysdlc.cs` и вставьте его в новый проект.

**Шаг 5. Добавьте зависимости**

Установите зависимости `InputSimulatorEx` и `Spectre.Console` с помощью менеджера пакетов NuGet и обновите файл «fn-audio-emulator.csproj».

**Шаг 6: Сборка EXE-файла**

Нажмите `Ctrl + B`, чтобы собрать проект. EXE-файл будет создан в папке `bin/Debug`.

**Шаг 7: Готово!**

Теперь вы можете использовать FN-Audio-Emulator с открытым исходным кодом и наслаждаться простым переключением музыки. С новым обновлением программа автоматически собирается через action при любом изменении кода.

Сообщество и поддержка
------------------------

Если у вас есть предложения или вопросы, не стесняйтесь создавать проблему или запрос на включение.

Программа будет получать обновления в течение длительного времени, и мы будем рады видеть вашу активность в сообществе.

**Создание проблемы**

Если вы нашли ошибку или хотите предложить новую функцию, создайте проблему на нашей странице GitHub. Мы будем рады рассмотреть ваше предложение и ответить на ваши вопросы.

**Запрос на включение**

Если вы хотите внести изменения в программу, создайте запрос на включение на нашей странице GitHub. Мы будем рады рассмотреть ваши изменения и включить их в программу.

**Обратная связь**

Мы всегда рады слышать от вас и готовы помочь. Если у вас есть вопросы или предложения, не стесняйтесь обращаться к нам.

Спасибо за вашу поддержку!
