using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;
using Microsoft.Win32;
using Spectre.Console;

class Program
{
    private static InputSimulator inputSimulator = new InputSimulator();
    private static bool isRunning = true;
    private static DateTime lastKeyPressTime = DateTime.MinValue;
    private static DateTime lastNextTrackKeyPressTime = DateTime.MinValue;
    private static DateTime lastPreviousTrackKeyPressTime = DateTime.MinValue;
    private static DateTime lastVolumeUpKeyPressTime = DateTime.MinValue;
    private static DateTime lastVolumeDownKeyPressTime = DateTime.MinValue;
    private static TimeSpan keyPressDelay = TimeSpan.FromMilliseconds(300);
    private static TimeSpan trackKeyPressDelay = TimeSpan.FromMilliseconds(500);
    private static TimeSpan volumeKeyPressDelay = TimeSpan.FromMilliseconds(100);
    private static bool isPlaying = true;

    private static VirtualKeyCode pausePlayKey = VirtualKeyCode.F2;
    private static VirtualKeyCode nextTrackKey = VirtualKeyCode.F4;
    private static VirtualKeyCode previousTrackKey = VirtualKeyCode.F8;
    private static VirtualKeyCode volumeUpKey = VirtualKeyCode.VK_9;
    private static VirtualKeyCode volumeDownKey = VirtualKeyCode.VK_0;
    internal static VirtualKeyCode toggleConsoleKey = VirtualKeyCode.F12;

    private static string currentLanguage = "en";
    private static Dictionary<string, Dictionary<string, string>> translations = new Dictionary<string, Dictionary<string, string>>
    {
        {
            "en", new Dictionary<string, string>
            {
                { "welcome", "[bold red]FN-Audio-Emulator 0.1 | Open Source github.com/iwantgirlfriend/fn-audio-emulator[/]" },
                { "help_command", "help - Show help" },
                { "enter_command", "[red]Enter command > [/]" },
                { "unknown_command", "Unknown command" },
                { "exiting", "Exiting application" },
                { "autostart_enabled", "Autostart enabled" },
                { "autostart_disabled", "Autostart disabled" },
                { "autostart_already_enabled", "autostart is already active" },
                { "setkey_usage", "Invalid command format. Usage: setkey <type> <key>" },
                { "unknown_key_type", "Unknown key type" },
                { "pauseplay_key_set", "Pause/Play key set to {0}" },
                { "nexttrack_key_set", "Next Track key set to {0}" },
                { "previoustrack_key_set", "Previous Track key set to {0}" },
                { "volumeup_key_set", "Volume Up key set to {0}" },
                { "volumedown_key_set", "Volume Down key set to {0}" },
                { "toggleconsole_key_set", "Toggle Console key set to {0}" },
                { "showkeys", "Pause/Play: {0}\nNext Track (only when song playing): {1}\nPrevious Track (only when song playing): {2}\nHide/Show Console: {5}\nVolume Up: {3}\nVolume Down: {4}" },
                { "help_text", "Available commands:\n  1. autostart - Enable autostart\n  2. offauto - Disable autostart\n  3. clear - Clear the terminal\n  4. setkey <type> <key> - Set custom key\n     - <type> can be: pauseplay, nexttrack, previoustrack, volumeup, volumedown, toggleconsole\n     - <key> is the name of the key from VirtualKeyCode enumeration\n     - Example: setkey pauseplay VK_1\n  5. setdelay <type> <delay> - Set key delay in milliseconds (for experienced users)\n     - <type> can be: pauseplay, nexttrack, previoustrack, volumeup, volumedown, toggleconsole\n     - <delay> is the delay in milliseconds\n     - Example: setdelay pauseplay 300\n  6. showkeys - Show current keys\n  7. russian - Switch to Russian language\n  8. english - Switch to English language\n  9. exit - Exit the application" },
                { "setdelay_usage", "Invalid command format. Usage: setdelay <type> <delay>" },
                { "delay_set", "{0} delay set to {1} ms" },
                { "offauto_error", "Autostart is already disabled" }
            }
        },
        {
            "ru", new Dictionary<string, string>
            {
                { "welcome", "[bold red]FN-Audio-Emulator 0.1 | Открытый исходный код github.com/iwantgirlfriend/fn-audio-emulator[/]" },
                { "help_command", "help - Показать доступные команды" },
                { "enter_command", "[red]Введите команду > [/]" },
                { "unknown_command", "Неизвестная команда" },
                { "exiting", "Выход из приложения" },
                { "autostart_enabled", "Автозапуск включен" },
                { "autostart_disabled", "Автозапуск выключен" },
                { "autostart_already_enabled", "autostart уже активен" },
                { "setkey_usage", "Неверный формат команды. Использование: setkey <тип> <клавиша>" },
                { "unknown_key_type", "Неизвестный тип клавиши" },
                { "pauseplay_key_set", "Клавиша Пауза/Воспроизведение установлена на {0}" },
                { "nexttrack_key_set", "Клавиша Следующий трек установлена на {0}" },
                { "previoustrack_key_set", "Клавиша Предыдущий трек установлена на {0}" },
                { "volumeup_key_set", "Клавиша Увеличение громкости установлена на {0}" },
                { "volumedown_key_set", "Клавиша Уменьшение громкости установлена на {0}" },
                { "toggleconsole_key_set", "Клавиша Переключения консоли установлена на {0}" },
                { "showkeys", "Пауза/Воспроизведение: {0}\nСледующий трек (только когда играет песня): {1}\nПредыдущий трек (только когда играет песня): {2}\nСкрыть/Открыть консоль: {5}\nУвеличение громкости: {3}\nУменьшение громкости: {4}" },
                { "help_text", "Доступные команды:\n  1. autostart - Включить автозапуск\n  2. offauto - Выключить автозапуск\n  3. clear - Очистить терминал\n  4. setkey <тип> <клавиша> - Установить пользовательскую клавишу\n     - <тип> может быть: pauseplay, nexttrack, previoustrack, volumeup, volumedown, toggleconsole\n     - <клавиша> - название клавиши из перечисления VirtualKeyCode\n     - Пример: setkey pauseplay VK_1\n  5. setdelay <тип> <задержка> - Установить задержку клавиши в миллисекундах (для опытных пользователей)\n     - <тип> может быть: pauseplay, nexttrack, previoustrack, volumeup, volumedown, toggleconsole\n     - <задержка> - задержка в миллисекундах\n     - Пример: setdelay pauseplay 300\n  6. showkeys - Показать текущие клавиши\n  7. russian - Переключить на Русский язык\n  8. english - Переключить на Английский язык\n  9. exit - Выйти из приложения" },
                { "setdelay_usage", "Неверный формат команды. Использование: setdelay <тип> <задержка>" },
                { "delay_set", "Задержка {0} установлена на {1} мс" },
                { "offauto_error", "Автозагрузка уже отключена" }
            }
        }
    };

    private static Mutex mutex = null;

    [DllImport("user32.dll")]
    private static extern bool SetForegroundWindow(IntPtr hWnd);

    static void Main(string[] args)
    {
        const string appName = "github.com/iwantgirlfriend/fn-audio-emulator";
        mutex = new Mutex(true, appName, out bool createdNew);

        if (!createdNew)
        {
            AnsiConsole.MarkupLine("[red]Another instance of the application is already running. Exiting...[/]");
            return;
        }

        AnsiConsole.MarkupLine(GetTranslation("welcome"));
        try
        {
            LoadSettings();
        }
        catch (Exception ex)
        {
            AnsiConsole.MarkupLine($"[red]Failed to load settings: {ex.Message}[/]");
        }
        PrintCurrentKeys();

        AnsiConsole.MarkupLine(GetTranslation("help_command"));

        Task.Run(() => HandleHotkeys());
        Task.Run(() => ConsoleHider.ToggleConsoleVisibility()); //shadowstart update

        while (isRunning)
        {
            var command = AnsiConsole.Prompt(
                new TextPrompt<string>(GetTranslation("enter_command"))
                    .PromptStyle("red"));
            HandleCommand(command);
        }

        mutex.ReleaseMutex();
    }

    private static void HandleHotkeys()
    {
        while (isRunning)
        {
            if (NativeMethods.IsKeyPressed(pausePlayKey) && DateTime.Now - lastKeyPressTime > keyPressDelay)
            {
                SendMediaKey(MediaKey.PlayPause);
                lastKeyPressTime = DateTime.Now;
                isPlaying = !isPlaying;
            }

            if (isPlaying)
            {
                if (NativeMethods.IsKeyPressed(nextTrackKey) && DateTime.Now - lastNextTrackKeyPressTime > trackKeyPressDelay)
                {
                    SendMediaKey(MediaKey.NextTrack);
                    lastNextTrackKeyPressTime = DateTime.Now;
                }

                if (NativeMethods.IsKeyPressed(previousTrackKey) && DateTime.Now - lastPreviousTrackKeyPressTime > trackKeyPressDelay)
                {
                    SendMediaKey(MediaKey.PreviousTrack);
                    lastPreviousTrackKeyPressTime = DateTime.Now;
                }
            }

            if (NativeMethods.IsKeyPressed(volumeUpKey) && DateTime.Now - lastVolumeUpKeyPressTime > volumeKeyPressDelay)
            {
                SendMediaKey(MediaKey.VolumeUp);
                lastVolumeUpKeyPressTime = DateTime.Now;
            }

            if (NativeMethods.IsKeyPressed(volumeDownKey) && DateTime.Now - lastVolumeDownKeyPressTime > volumeKeyPressDelay)
            {
                SendMediaKey(MediaKey.VolumeDown);
                lastVolumeDownKeyPressTime = DateTime.Now;
            }

            System.Threading.Thread.Sleep(100);
        }
    }

    private static void SendMediaKey(MediaKey key)
    {
        inputSimulator.Keyboard.KeyPress((VirtualKeyCode)key);
    }

    private static void HandleCommand(string command)
    {
        var parts = command.Split(' ');

        try
        {
            switch (parts[0].ToLower())
            {
                case "setkey":
                    if (parts.Length == 3 && Enum.TryParse(parts[2], out VirtualKeyCode newKey))
                    {
                        switch (parts[1].ToLower())
                        {
                            case "pauseplay":
                                pausePlayKey = newKey;
                                AnsiConsole.MarkupLine(string.Format(GetTranslation("pauseplay_key_set"), newKey));
                                break;
                            case "nexttrack":
                                nextTrackKey = newKey;
                                AnsiConsole.MarkupLine(string.Format(GetTranslation("nexttrack_key_set"), newKey));
                                break;
                            case "previoustrack":
                                previousTrackKey = newKey;
                                AnsiConsole.MarkupLine(string.Format(GetTranslation("previoustrack_key_set"), newKey));
                                break;
                            case "volumeup":
                                volumeUpKey = newKey;
                                AnsiConsole.MarkupLine(string.Format(GetTranslation("volumeup_key_set"), newKey));
                                break;
                            case "volumedown":
                                volumeDownKey = newKey;
                                AnsiConsole.MarkupLine(string.Format(GetTranslation("volumedown_key_set"), newKey));
                                break;
                            case "toggleconsole":
                                toggleConsoleKey = newKey;
                                AnsiConsole.MarkupLine(string.Format(GetTranslation("toggleconsole_key_set"), newKey));
                                break;
                            default:
                                AnsiConsole.MarkupLine(GetTranslation("unknown_key_type"));
                                break;
                        }
                        SaveSettings();
                    }
                    else
                    {
                        AnsiConsole.MarkupLine(GetTranslation("setkey_usage"));
                    }
                    break;
                case "setdelay":
                    if (parts.Length == 3 && int.TryParse(parts[2], out int newDelay))
                    {
                        switch (parts[1].ToLower())
                        {
                            case "pauseplay":
                                keyPressDelay = TimeSpan.FromMilliseconds(newDelay);
                                AnsiConsole.MarkupLine(string.Format(GetTranslation("delay_set"), "Pause/Play", newDelay));
                                break;
                            case "nexttrack":
                                trackKeyPressDelay = TimeSpan.FromMilliseconds(newDelay);
                                AnsiConsole.MarkupLine(string.Format(GetTranslation("delay_set"), "Next Track", newDelay));
                                break;
                            case "previoustrack":
                                trackKeyPressDelay = TimeSpan.FromMilliseconds(newDelay);
                                AnsiConsole.MarkupLine(string.Format(GetTranslation("delay_set"), "Previous Track", newDelay));
                                break;
                            case "volumeup":
                                volumeKeyPressDelay = TimeSpan.FromMilliseconds(newDelay);
                                AnsiConsole.MarkupLine(string.Format(GetTranslation("delay_set"), "Volume Up", newDelay));
                                break;
                            case "volumedown":
                                volumeKeyPressDelay = TimeSpan.FromMilliseconds(newDelay);
                                AnsiConsole.MarkupLine(string.Format(GetTranslation("delay_set"), "Volume Down", newDelay));
                                break;
                            case "toggleconsole":
                                AnsiConsole.MarkupLine(string.Format(GetTranslation("delay_set"), "Toggle Console", newDelay));
                                break;
                            default:
                                AnsiConsole.MarkupLine(GetTranslation("unknown_key_type"));
                                break;
                        }
                        SaveSettings();
                    }
                    else
                    {
                        AnsiConsole.MarkupLine(GetTranslation("setdelay_usage"));
                    }
                    break;
                case "autostart":
                    if (IsAutostartEnabled())
                    {
                        AnsiConsole.MarkupLine(GetTranslation("autostart_already_enabled"));
                    }
                    else
                    {
                        EnableAutostart();
                        AnsiConsole.MarkupLine(GetTranslation("autostart_enabled"));
                    }
                    break;
                case "offauto":
                    if (!IsAutostartEnabled())
                    {
                        AnsiConsole.MarkupLine(GetTranslation("offauto_error"));
                    }
                    else
                    {
                        DisableAutostart();
                        AnsiConsole.MarkupLine(GetTranslation("autostart_disabled"));
                    }
                    break;
                case "showkeys":
                    PrintCurrentKeys();
                    break;
                case "help":
                    ShowHelp();
                    break;
                case "exit":
                    isRunning = false;
                    AnsiConsole.MarkupLine(GetTranslation("exiting"));
                    break;
                case "russian":
                    currentLanguage = "ru";
                    AnsiConsole.MarkupLine("Язык изменен на Русский.");
                    SaveSettings();
                    break;
                case "english":
                    currentLanguage = "en";
                    AnsiConsole.MarkupLine("Language switched to English.");
                    SaveSettings();
                    break;
                case "clear":
                    AnsiConsole.Clear();
                    break;
                default:
                    AnsiConsole.MarkupLine(GetTranslation("unknown_command"));
                    break;
            }
        }
        catch (Exception ex)
        {
            AnsiConsole.MarkupLine($"[red]Error handling command: {ex.Message}[/]");
        }
    }

    private static void EnableAutostart()
    {
        string appPath = Process.GetCurrentProcess().MainModule.FileName;
        SetRegistryKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", appPath);
    }

    private static void DisableAutostart()
    {
        string appName = Process.GetCurrentProcess().ProcessName;
        RemoveRegistryKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", appName);
    }

    private static void SetRegistryKey(string subKey, string value)
    {
        try
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(subKey, true))
            {
                if (key != null)
                {
                    key.SetValue(Process.GetCurrentProcess().ProcessName, value);
                }
            }
        }
        catch (Exception ex)
        {
            AnsiConsole.MarkupLine($"[red]Failed to set registry key: {ex.Message}[/]");
        }
    }

    private static void RemoveRegistryKey(string subKey, string name)
    {
        try
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(subKey, true))
            {
                if (key != null)
                {
                    key.DeleteValue(name, false);
                }
            }
        }
        catch (Exception ex)
        {
            AnsiConsole.MarkupLine($"[red]Failed to remove registry key: {ex.Message}[/]");
        }
    }

    private static void SaveSettings()
    {
        try
        {
            System.IO.File.WriteAllText("settings.txt", $"{pausePlayKey}\n{nextTrackKey}\n{previousTrackKey}\n{volumeUpKey}\n{volumeDownKey}\n{toggleConsoleKey}\n{currentLanguage}\n{keyPressDelay.TotalMilliseconds}\n{trackKeyPressDelay.TotalMilliseconds}\n{volumeKeyPressDelay.TotalMilliseconds}");
        }
        catch (Exception ex)
        {
            AnsiConsole.MarkupLine($"[red]Failed to save settings: {ex.Message}[/]");
        }
    }

    private static void LoadSettings()
    {
        try
        {
            if (System.IO.File.Exists("settings.txt"))
            {
                var lines = System.IO.File.ReadAllLines("settings.txt");
                if (lines.Length == 10 && Enum.TryParse(lines[0], out VirtualKeyCode ppKey) && Enum.TryParse(lines[1], out VirtualKeyCode ntKey) && Enum.TryParse(lines[2], out VirtualKeyCode ptKey) && Enum.TryParse(lines[3], out VirtualKeyCode vuKey) && Enum.TryParse(lines[4], out VirtualKeyCode vdKey) && Enum.TryParse(lines[5], out VirtualKeyCode tcKey) && double.TryParse(lines[7], out double ppDelay) && double.TryParse(lines[8], out double ntDelay) && double.TryParse(lines[9], out double vuDelay))
                {
                    pausePlayKey = ppKey;
                    nextTrackKey = ntKey;
                    previousTrackKey = ptKey;
                    volumeUpKey = vuKey;
                    volumeDownKey = vdKey;
                    toggleConsoleKey = tcKey;
                    currentLanguage = lines[6];
                    keyPressDelay = TimeSpan.FromMilliseconds(ppDelay);
                    trackKeyPressDelay = TimeSpan.FromMilliseconds(ntDelay);
                    volumeKeyPressDelay = TimeSpan.FromMilliseconds(vuDelay);
                }
            }
        }
        catch (Exception ex)
        {
            AnsiConsole.MarkupLine($"[red]Failed to load settings: {ex.Message}[/]");
        }
    }

    private static void PrintCurrentKeys()
    {
        var panel = new Panel(
            new Rows(
                new Text(string.Format(GetTranslation("showkeys"), pausePlayKey, nextTrackKey, previousTrackKey, GetKeyName(volumeUpKey), GetKeyName(volumeDownKey), GetKeyName(toggleConsoleKey)))
            )
        )
        .Header("Current Keys")
        .Border(BoxBorder.Rounded)
        .BorderColor(Color.Red);

        AnsiConsole.Write(panel);
    }

    private static string GetKeyName(VirtualKeyCode keyCode)
    {
        switch (keyCode)
        {
            case VirtualKeyCode.VK_9:
                return "9";
            case VirtualKeyCode.VK_0:
                return "0";
            default:
                return keyCode.ToString();
        }
    }

    private static void ShowHelp()
    {
        var helpText = GetTranslation("help_text");
        var panel = new Panel(
            new Markup(helpText)
        )
        .Header("Help")
        .Border(BoxBorder.Rounded)
        .BorderColor(Color.Red);

        AnsiConsole.Write(panel);
    }

    private static string GetTranslation(string key)
    {
        if (translations.ContainsKey(currentLanguage) && translations[currentLanguage].ContainsKey(key))
        {
            return translations[currentLanguage][key];
        }
        return key;
    }

    private static bool IsAutostartEnabled()
    {
        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", false))
        {
            return key?.GetValue(Process.GetCurrentProcess().ProcessName) != null;
        }
    }
}

public enum MediaKey
{
    PlayPause = VirtualKeyCode.MEDIA_PLAY_PAUSE,
    NextTrack = VirtualKeyCode.MEDIA_NEXT_TRACK,
    PreviousTrack = VirtualKeyCode.MEDIA_PREV_TRACK,
    VolumeUp = VirtualKeyCode.VOLUME_UP,
    VolumeDown = VirtualKeyCode.VOLUME_DOWN
}

public static class NativeMethods
{
    [DllImport("user32.dll")]
    private static extern short GetAsyncKeyState(int vKey);

    public static bool IsKeyPressed(VirtualKeyCode keyCode)
    {
        return (GetAsyncKeyState((int)keyCode) & 0x8000) != 0;
    }
}

public static class ConsoleHider
{
    private const int SW_HIDE = 0;
    private const int SW_SHOW = 5;
    private static bool isHidden = false;

    [DllImport("kernel32.dll")]
    private static extern IntPtr GetConsoleWindow();

    [DllImport("user32.dll")]
    private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    public static async Task ToggleConsoleVisibility()
    {
        IntPtr consoleWindow = GetConsoleWindow();

        while (true)
        {
            if (NativeMethods.IsKeyPressed(Program.toggleConsoleKey))
            {
                isHidden = !isHidden;
                ShowWindow(consoleWindow, isHidden ? SW_HIDE : SW_SHOW);
                await Task.Delay(250);
            }
            await Task.Delay(50);
        }
    }
}