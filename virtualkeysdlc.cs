using InputSimulatorEx.Native;
using System.Collections.Generic;

namespace VirtualKeysDlc
{
    public static class KeyAliases
    {
        public static readonly Dictionary<string, VirtualKeyCode> Aliases = new Dictionary<string, VirtualKeyCode>();

        static KeyAliases()
        {
            AddAlias("VK_LBUTTON", VirtualKeyCode.LBUTTON);
            AddAlias("VK_RBUTTON", VirtualKeyCode.RBUTTON);
            AddAlias("VK_CANCEL", VirtualKeyCode.CANCEL);
            AddAlias("VK_MBUTTON", VirtualKeyCode.MBUTTON);
            AddAlias("VK_XBUTTON1", VirtualKeyCode.XBUTTON1);
            AddAlias("VK_XBUTTON2", VirtualKeyCode.XBUTTON2);
            AddAlias("VK_BACK", VirtualKeyCode.BACK);
            AddAlias("VK_TAB", VirtualKeyCode.TAB);
            AddAlias("VK_CLEAR", VirtualKeyCode.CLEAR);
            AddAlias("VK_RETURN", VirtualKeyCode.RETURN);
            AddAlias("VK_SHIFT", VirtualKeyCode.SHIFT);
            AddAlias("VK_CONTROL", VirtualKeyCode.CONTROL);
            AddAlias("VK_MENU", VirtualKeyCode.MENU);
            AddAlias("VK_PAUSE", VirtualKeyCode.PAUSE);
            AddAlias("VK_CAPITAL", VirtualKeyCode.CAPITAL);
            AddAlias("VK_KANA", VirtualKeyCode.KANA);
            AddAlias("VK_HANGUL", VirtualKeyCode.HANGUL);
            AddAlias("VK_JUNJA", VirtualKeyCode.JUNJA);
            AddAlias("VK_FINAL", VirtualKeyCode.FINAL);
            AddAlias("VK_HANJA", VirtualKeyCode.HANJA);
            AddAlias("VK_KANJI", VirtualKeyCode.KANJI);
            AddAlias("VK_ESCAPE", VirtualKeyCode.ESCAPE);
            AddAlias("VK_CONVERT", VirtualKeyCode.CONVERT);
            AddAlias("VK_NONCONVERT", VirtualKeyCode.NONCONVERT);
            AddAlias("VK_ACCEPT", VirtualKeyCode.ACCEPT);
            AddAlias("VK_MODECHANGE", VirtualKeyCode.MODECHANGE);
            AddAlias("VK_SPACE", VirtualKeyCode.SPACE);
            AddAlias("VK_PRIOR", VirtualKeyCode.PRIOR);
            AddAlias("VK_NEXT", VirtualKeyCode.NEXT);
            AddAlias("VK_END", VirtualKeyCode.END);
            AddAlias("VK_HOME", VirtualKeyCode.HOME);
            AddAlias("VK_LEFT", VirtualKeyCode.LEFT);
            AddAlias("VK_UP", VirtualKeyCode.UP);
            AddAlias("VK_RIGHT", VirtualKeyCode.RIGHT);
            AddAlias("VK_DOWN", VirtualKeyCode.DOWN);
            AddAlias("VK_SELECT", VirtualKeyCode.SELECT);
            AddAlias("VK_PRINT", VirtualKeyCode.PRINT);
            AddAlias("VK_EXECUTE", VirtualKeyCode.EXECUTE);
            AddAlias("VK_SNAPSHOT", VirtualKeyCode.SNAPSHOT);
            AddAlias("VK_INSERT", VirtualKeyCode.INSERT);
            AddAlias("VK_DELETE", VirtualKeyCode.DELETE);
            AddAlias("VK_HELP", VirtualKeyCode.HELP);
            AddAlias("VK_0", VirtualKeyCode.VK_0);
            AddAlias("VK_1", VirtualKeyCode.VK_1);
            AddAlias("VK_2", VirtualKeyCode.VK_2);
            AddAlias("VK_3", VirtualKeyCode.VK_3);
            AddAlias("VK_4", VirtualKeyCode.VK_4);
            AddAlias("VK_5", VirtualKeyCode.VK_5);
            AddAlias("VK_6", VirtualKeyCode.VK_6);
            AddAlias("VK_7", VirtualKeyCode.VK_7);
            AddAlias("VK_8", VirtualKeyCode.VK_8);
            AddAlias("VK_9", VirtualKeyCode.VK_9);
            AddAlias("VK_A", VirtualKeyCode.VK_A);
            AddAlias("VK_B", VirtualKeyCode.VK_B);
            AddAlias("VK_C", VirtualKeyCode.VK_C);
            AddAlias("VK_D", VirtualKeyCode.VK_D);
            AddAlias("VK_E", VirtualKeyCode.VK_E);
            AddAlias("VK_F", VirtualKeyCode.VK_F);
            AddAlias("VK_G", VirtualKeyCode.VK_G);
            AddAlias("VK_H", VirtualKeyCode.VK_H);
            AddAlias("VK_I", VirtualKeyCode.VK_I);
            AddAlias("VK_J", VirtualKeyCode.VK_J);
            AddAlias("VK_K", VirtualKeyCode.VK_K);
            AddAlias("VK_L", VirtualKeyCode.VK_L);
            AddAlias("VK_M", VirtualKeyCode.VK_M);
            AddAlias("VK_N", VirtualKeyCode.VK_N);
            AddAlias("VK_O", VirtualKeyCode.VK_O);
            AddAlias("VK_P", VirtualKeyCode.VK_P);
            AddAlias("VK_Q", VirtualKeyCode.VK_Q);
            AddAlias("VK_R", VirtualKeyCode.VK_R);
            AddAlias("VK_S", VirtualKeyCode.VK_S);
            AddAlias("VK_T", VirtualKeyCode.VK_T);
            AddAlias("VK_U", VirtualKeyCode.VK_U);
            AddAlias("VK_V", VirtualKeyCode.VK_V);
            AddAlias("VK_W", VirtualKeyCode.VK_W);
            AddAlias("VK_X", VirtualKeyCode.VK_X);
            AddAlias("VK_Y", VirtualKeyCode.VK_Y);
            AddAlias("VK_Z", VirtualKeyCode.VK_Z);
            AddAlias("VK_LWIN", VirtualKeyCode.LWIN);
            AddAlias("VK_RWIN", VirtualKeyCode.RWIN);
            AddAlias("VK_APPS", VirtualKeyCode.APPS);
            AddAlias("VK_SLEEP", VirtualKeyCode.SLEEP);
            AddAlias("VK_NUMPAD0", VirtualKeyCode.NUMPAD0);
            AddAlias("VK_NUMPAD1", VirtualKeyCode.NUMPAD1);
            AddAlias("VK_NUMPAD2", VirtualKeyCode.NUMPAD2);
            AddAlias("VK_NUMPAD3", VirtualKeyCode.NUMPAD3);
            AddAlias("VK_NUMPAD4", VirtualKeyCode.NUMPAD4);
            AddAlias("VK_NUMPAD5", VirtualKeyCode.NUMPAD5);
            AddAlias("VK_NUMPAD6", VirtualKeyCode.NUMPAD6);
            AddAlias("VK_NUMPAD7", VirtualKeyCode.NUMPAD7);
            AddAlias("VK_NUMPAD8", VirtualKeyCode.NUMPAD8);
            AddAlias("VK_NUMPAD9", VirtualKeyCode.NUMPAD9);
            AddAlias("VK_MULTIPLY", VirtualKeyCode.MULTIPLY);
            AddAlias("VK_ADD", VirtualKeyCode.ADD);
            AddAlias("VK_SEPARATOR", VirtualKeyCode.SEPARATOR);
            AddAlias("VK_SUBTRACT", VirtualKeyCode.SUBTRACT);
            AddAlias("VK_DECIMAL", VirtualKeyCode.DECIMAL);
            AddAlias("VK_DIVIDE", VirtualKeyCode.DIVIDE);
            AddAlias("VK_F1", VirtualKeyCode.F1);
            AddAlias("VK_F2", VirtualKeyCode.F2);
            AddAlias("VK_F3", VirtualKeyCode.F3);
            AddAlias("VK_F4", VirtualKeyCode.F4);
            AddAlias("VK_F5", VirtualKeyCode.F5);
            AddAlias("VK_F6", VirtualKeyCode.F6);
            AddAlias("VK_F7", VirtualKeyCode.F7);
            AddAlias("VK_F8", VirtualKeyCode.F8);
            AddAlias("VK_F9", VirtualKeyCode.F9);
            AddAlias("VK_F10", VirtualKeyCode.F10);
            AddAlias("VK_F11", VirtualKeyCode.F11);
            AddAlias("VK_F12", VirtualKeyCode.F12);
            AddAlias("VK_F13", VirtualKeyCode.F13);
            AddAlias("VK_F14", VirtualKeyCode.F14);
            AddAlias("VK_F15", VirtualKeyCode.F15);
            AddAlias("VK_F16", VirtualKeyCode.F16);
            AddAlias("VK_F17", VirtualKeyCode.F17);
            AddAlias("VK_F18", VirtualKeyCode.F18);
            AddAlias("VK_F19", VirtualKeyCode.F19);
            AddAlias("VK_F20", VirtualKeyCode.F20);
            AddAlias("VK_F21", VirtualKeyCode.F21);
            AddAlias("VK_F22", VirtualKeyCode.F22);
            AddAlias("VK_F23", VirtualKeyCode.F23);
            AddAlias("VK_F24", VirtualKeyCode.F24);
            AddAlias("VK_NUMLOCK", VirtualKeyCode.NUMLOCK);
            AddAlias("VK_SCROLL", VirtualKeyCode.SCROLL);
            AddAlias("VK_LSHIFT", VirtualKeyCode.LSHIFT);
            AddAlias("VK_RSHIFT", VirtualKeyCode.RSHIFT);
            AddAlias("VK_LCONTROL", VirtualKeyCode.LCONTROL);
            AddAlias("VK_RCONTROL", VirtualKeyCode.RCONTROL);
            AddAlias("VK_LMENU", VirtualKeyCode.LMENU);
            AddAlias("VK_RMENU", VirtualKeyCode.RMENU);
            AddAlias("VK_BROWSER_BACK", VirtualKeyCode.BROWSER_BACK);
            AddAlias("VK_BROWSER_FORWARD", VirtualKeyCode.BROWSER_FORWARD);
            AddAlias("VK_BROWSER_REFRESH", VirtualKeyCode.BROWSER_REFRESH);
            AddAlias("VK_BROWSER_STOP", VirtualKeyCode.BROWSER_STOP);
            AddAlias("VK_BROWSER_SEARCH", VirtualKeyCode.BROWSER_SEARCH);
            AddAlias("VK_BROWSER_FAVORITES", VirtualKeyCode.BROWSER_FAVORITES);
            AddAlias("VK_BROWSER_HOME", VirtualKeyCode.BROWSER_HOME);
            AddAlias("VK_VOLUME_MUTE", VirtualKeyCode.VOLUME_MUTE);
            AddAlias("VK_VOLUME_DOWN", VirtualKeyCode.VOLUME_DOWN);
            AddAlias("VK_VOLUME_UP", VirtualKeyCode.VOLUME_UP);
            AddAlias("VK_MEDIA_NEXT_TRACK", VirtualKeyCode.MEDIA_NEXT_TRACK);
            AddAlias("VK_MEDIA_PREV_TRACK", VirtualKeyCode.MEDIA_PREV_TRACK);
            AddAlias("VK_MEDIA_STOP", VirtualKeyCode.MEDIA_STOP);
            AddAlias("VK_MEDIA_PLAY_PAUSE", VirtualKeyCode.MEDIA_PLAY_PAUSE);
            AddAlias("VK_LAUNCH_MAIL", VirtualKeyCode.LAUNCH_MAIL);
            AddAlias("VK_LAUNCH_MEDIA_SELECT", VirtualKeyCode.LAUNCH_MEDIA_SELECT);
            AddAlias("VK_LAUNCH_APP1", VirtualKeyCode.LAUNCH_APP1);
            AddAlias("VK_LAUNCH_APP2", VirtualKeyCode.LAUNCH_APP2);
            AddAlias("VK_OEM_1", VirtualKeyCode.OEM_1);
            AddAlias("VK_OEM_PLUS", VirtualKeyCode.OEM_PLUS);
            AddAlias("VK_OEM_COMMA", VirtualKeyCode.OEM_COMMA);
            AddAlias("VK_OEM_MINUS", VirtualKeyCode.OEM_MINUS);
            AddAlias("VK_OEM_PERIOD", VirtualKeyCode.OEM_PERIOD);
            AddAlias("VK_OEM_2", VirtualKeyCode.OEM_2);
            AddAlias("VK_OEM_3", VirtualKeyCode.OEM_3);
            AddAlias("VK_OEM_4", VirtualKeyCode.OEM_4);
            AddAlias("VK_OEM_5", VirtualKeyCode.OEM_5);
            AddAlias("VK_OEM_6", VirtualKeyCode.OEM_6);
            AddAlias("VK_OEM_7", VirtualKeyCode.OEM_7);
            AddAlias("VK_OEM_8", VirtualKeyCode.OEM_8);
            AddAlias("VK_OEM_102", VirtualKeyCode.OEM_102);
            AddAlias("VK_PROCESSKEY", VirtualKeyCode.PROCESSKEY);
            AddAlias("VK_PACKET", VirtualKeyCode.PACKET);
            AddAlias("VK_ATTN", VirtualKeyCode.ATTN);
            AddAlias("VK_CRSEL", VirtualKeyCode.CRSEL);
            AddAlias("VK_EXSEL", VirtualKeyCode.EXSEL);
            AddAlias("VK_EREOF", VirtualKeyCode.EREOF);
            AddAlias("VK_PLAY", VirtualKeyCode.PLAY);
            AddAlias("VK_ZOOM", VirtualKeyCode.ZOOM);
            AddAlias("VK_NONAME", VirtualKeyCode.NONAME);
            AddAlias("VK_PA1", VirtualKeyCode.PA1);
            AddAlias("VK_OEM_CLEAR", VirtualKeyCode.OEM_CLEAR);
        }

        private static void AddAlias(string key, VirtualKeyCode value)
        {
            if (!Aliases.ContainsKey(key))
            {
                Aliases.Add(key, value);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"Duplicate key found in Aliases: {key}");
            }
        }
    }

    public static class KeyNames
    {
        public static readonly Dictionary<VirtualKeyCode, string> KeyNamesDict = new Dictionary<VirtualKeyCode, string>();

        static KeyNames()
        {
            AddKeyName(VirtualKeyCode.LBUTTON, "Left Mouse Button");
            AddKeyName(VirtualKeyCode.RBUTTON, "Right Mouse Button");
            AddKeyName(VirtualKeyCode.CANCEL, "Cancel");
            AddKeyName(VirtualKeyCode.MBUTTON, "Middle Mouse Button");
            AddKeyName(VirtualKeyCode.XBUTTON1, "X1 Mouse Button");
            AddKeyName(VirtualKeyCode.XBUTTON2, "X2 Mouse Button");
            AddKeyName(VirtualKeyCode.BACK, "Backspace");
            AddKeyName(VirtualKeyCode.TAB, "Tab");
            AddKeyName(VirtualKeyCode.CLEAR, "Clear");
            AddKeyName(VirtualKeyCode.RETURN, "Enter");
            AddKeyName(VirtualKeyCode.SHIFT, "Shift");
            AddKeyName(VirtualKeyCode.CONTROL, "Ctrl");
            AddKeyName(VirtualKeyCode.MENU, "Alt");
            AddKeyName(VirtualKeyCode.PAUSE, "Pause");
            AddKeyName(VirtualKeyCode.CAPITAL, "Caps Lock");
            AddKeyName(VirtualKeyCode.KANA, "Kana");
            AddKeyName(VirtualKeyCode.HANGUL, "Hangul");
            AddKeyName(VirtualKeyCode.JUNJA, "Junja");
            AddKeyName(VirtualKeyCode.FINAL, "Final");
            AddKeyName(VirtualKeyCode.HANJA, "Hanja");
            AddKeyName(VirtualKeyCode.KANJI, "Kanji");
            AddKeyName(VirtualKeyCode.ESCAPE, "Esc");
            AddKeyName(VirtualKeyCode.CONVERT, "Convert");
            AddKeyName(VirtualKeyCode.NONCONVERT, "NonConvert");
            AddKeyName(VirtualKeyCode.ACCEPT, "Accept");
            AddKeyName(VirtualKeyCode.MODECHANGE, "Mode Change");
            AddKeyName(VirtualKeyCode.SPACE, "Space");
            AddKeyName(VirtualKeyCode.PRIOR, "Page Up");
            AddKeyName(VirtualKeyCode.NEXT, "Page Down");
            AddKeyName(VirtualKeyCode.END, "End");
            AddKeyName(VirtualKeyCode.HOME, "Home");
            AddKeyName(VirtualKeyCode.LEFT, "Left Arrow");
            AddKeyName(VirtualKeyCode.UP, "Up Arrow");
            AddKeyName(VirtualKeyCode.RIGHT, "Right Arrow");
            AddKeyName(VirtualKeyCode.DOWN, "Down Arrow");
            AddKeyName(VirtualKeyCode.SELECT, "Select");
            AddKeyName(VirtualKeyCode.PRINT, "Print");
            AddKeyName(VirtualKeyCode.EXECUTE, "Execute");
            AddKeyName(VirtualKeyCode.SNAPSHOT, "Print Screen");
            AddKeyName(VirtualKeyCode.INSERT, "Insert");
            AddKeyName(VirtualKeyCode.DELETE, "Delete");
            AddKeyName(VirtualKeyCode.HELP, "Help");
            AddKeyName(VirtualKeyCode.VK_0, "0");
            AddKeyName(VirtualKeyCode.VK_1, "1");
            AddKeyName(VirtualKeyCode.VK_2, "2");
            AddKeyName(VirtualKeyCode.VK_3, "3");
            AddKeyName(VirtualKeyCode.VK_4, "4");
            AddKeyName(VirtualKeyCode.VK_5, "5");
            AddKeyName(VirtualKeyCode.VK_6, "6");
            AddKeyName(VirtualKeyCode.VK_7, "7");
            AddKeyName(VirtualKeyCode.VK_8, "8");
            AddKeyName(VirtualKeyCode.VK_9, "9");
            AddKeyName(VirtualKeyCode.VK_A, "A");
            AddKeyName(VirtualKeyCode.VK_B, "B");
            AddKeyName(VirtualKeyCode.VK_C, "C");
            AddKeyName(VirtualKeyCode.VK_D, "D");
            AddKeyName(VirtualKeyCode.VK_E, "E");
            AddKeyName(VirtualKeyCode.VK_F, "F");
            AddKeyName(VirtualKeyCode.VK_G, "G");
            AddKeyName(VirtualKeyCode.VK_H, "H");
            AddKeyName(VirtualKeyCode.VK_I, "I");
            AddKeyName(VirtualKeyCode.VK_J, "J");
            AddKeyName(VirtualKeyCode.VK_K, "K");
            AddKeyName(VirtualKeyCode.VK_L, "L");
            AddKeyName(VirtualKeyCode.VK_M, "M");
            AddKeyName(VirtualKeyCode.VK_N, "N");
            AddKeyName(VirtualKeyCode.VK_O, "O");
            AddKeyName(VirtualKeyCode.VK_P, "P");
            AddKeyName(VirtualKeyCode.VK_Q, "Q");
            AddKeyName(VirtualKeyCode.VK_R, "R");
            AddKeyName(VirtualKeyCode.VK_S, "S");
            AddKeyName(VirtualKeyCode.VK_T, "T");
            AddKeyName(VirtualKeyCode.VK_U, "U");
            AddKeyName(VirtualKeyCode.VK_V, "V");
            AddKeyName(VirtualKeyCode.VK_W, "W");
            AddKeyName(VirtualKeyCode.VK_X, "X");
            AddKeyName(VirtualKeyCode.VK_Y, "Y");
            AddKeyName(VirtualKeyCode.VK_Z, "Z");
            AddKeyName(VirtualKeyCode.LWIN, "Left Windows");
            AddKeyName(VirtualKeyCode.RWIN, "Right Windows");
            AddKeyName(VirtualKeyCode.APPS, "Applications");
            AddKeyName(VirtualKeyCode.SLEEP, "Sleep");
            AddKeyName(VirtualKeyCode.NUMPAD0, "Num 0");
            AddKeyName(VirtualKeyCode.NUMPAD1, "Num 1");
            AddKeyName(VirtualKeyCode.NUMPAD2, "Num 2");
            AddKeyName(VirtualKeyCode.NUMPAD3, "Num 3");
            AddKeyName(VirtualKeyCode.NUMPAD4, "Num 4");
            AddKeyName(VirtualKeyCode.NUMPAD5, "Num 5");
            AddKeyName(VirtualKeyCode.NUMPAD6, "Num 6");
            AddKeyName(VirtualKeyCode.NUMPAD7, "Num 7");
            AddKeyName(VirtualKeyCode.NUMPAD8, "Num 8");
            AddKeyName(VirtualKeyCode.NUMPAD9, "Num 9");
            AddKeyName(VirtualKeyCode.MULTIPLY, "Num *");
            AddKeyName(VirtualKeyCode.ADD, "Num +");
            AddKeyName(VirtualKeyCode.SEPARATOR, "Separator");
            AddKeyName(VirtualKeyCode.SUBTRACT, "Num -");
            AddKeyName(VirtualKeyCode.DECIMAL, "Num .");
            AddKeyName(VirtualKeyCode.DIVIDE, "Num /");
            AddKeyName(VirtualKeyCode.F1, "F1");
            AddKeyName(VirtualKeyCode.F2, "F2");
            AddKeyName(VirtualKeyCode.F3, "F3");
            AddKeyName(VirtualKeyCode.F4, "F4");
            AddKeyName(VirtualKeyCode.F5, "F5");
            AddKeyName(VirtualKeyCode.F6, "F6");
            AddKeyName(VirtualKeyCode.F7, "F7");
            AddKeyName(VirtualKeyCode.F8, "F8");
            AddKeyName(VirtualKeyCode.F9, "F9");
            AddKeyName(VirtualKeyCode.F10, "F10");
            AddKeyName(VirtualKeyCode.F11, "F11");
            AddKeyName(VirtualKeyCode.F12, "F12");
            AddKeyName(VirtualKeyCode.F13, "F13");
            AddKeyName(VirtualKeyCode.F14, "F14");
            AddKeyName(VirtualKeyCode.F15, "F15");
            AddKeyName(VirtualKeyCode.F16, "F16");
            AddKeyName(VirtualKeyCode.F17, "F17");
            AddKeyName(VirtualKeyCode.F18, "F18");
            AddKeyName(VirtualKeyCode.F19, "F19");
            AddKeyName(VirtualKeyCode.F20, "F20");
            AddKeyName(VirtualKeyCode.F21, "F21");
            AddKeyName(VirtualKeyCode.F22, "F22");
            AddKeyName(VirtualKeyCode.F23, "F23");
            AddKeyName(VirtualKeyCode.F24, "F24");
            AddKeyName(VirtualKeyCode.NUMLOCK, "Num Lock");
            AddKeyName(VirtualKeyCode.SCROLL, "Scroll Lock");
            AddKeyName(VirtualKeyCode.LSHIFT, "Left Shift");
            AddKeyName(VirtualKeyCode.RSHIFT, "Right Shift");
            AddKeyName(VirtualKeyCode.LCONTROL, "Left Ctrl");
            AddKeyName(VirtualKeyCode.RCONTROL, "Right Ctrl");
            AddKeyName(VirtualKeyCode.LMENU, "Left Alt");
            AddKeyName(VirtualKeyCode.RMENU, "Right Alt");
            AddKeyName(VirtualKeyCode.BROWSER_BACK, "Browser Back");
            AddKeyName(VirtualKeyCode.BROWSER_FORWARD, "Browser Forward");
            AddKeyName(VirtualKeyCode.BROWSER_REFRESH, "Browser Refresh");
            AddKeyName(VirtualKeyCode.BROWSER_STOP, "Browser Stop");
            AddKeyName(VirtualKeyCode.BROWSER_SEARCH, "Browser Search");
            AddKeyName(VirtualKeyCode.BROWSER_FAVORITES, "Browser Favorites");
            AddKeyName(VirtualKeyCode.BROWSER_HOME, "Browser Home");
            AddKeyName(VirtualKeyCode.VOLUME_MUTE, "Volume Mute");
            AddKeyName(VirtualKeyCode.VOLUME_DOWN, "Volume Down");
            AddKeyName(VirtualKeyCode.VOLUME_UP, "Volume Up");
            AddKeyName(VirtualKeyCode.MEDIA_NEXT_TRACK, "Next Track");
            AddKeyName(VirtualKeyCode.MEDIA_PREV_TRACK, "Previous Track");
            AddKeyName(VirtualKeyCode.MEDIA_STOP, "Media Stop");
            AddKeyName(VirtualKeyCode.MEDIA_PLAY_PAUSE, "Play/Pause");
            AddKeyName(VirtualKeyCode.LAUNCH_MAIL, "Launch Mail");
            AddKeyName(VirtualKeyCode.LAUNCH_MEDIA_SELECT, "Select Media");
            AddKeyName(VirtualKeyCode.LAUNCH_APP1, "Launch App1");
            AddKeyName(VirtualKeyCode.LAUNCH_APP2, "Launch App2");
            AddKeyName(VirtualKeyCode.OEM_1, "OEM 1");
            AddKeyName(VirtualKeyCode.OEM_PLUS, "+");
            AddKeyName(VirtualKeyCode.OEM_COMMA, ",");
            AddKeyName(VirtualKeyCode.OEM_MINUS, "-");
            AddKeyName(VirtualKeyCode.OEM_PERIOD, ".");
            AddKeyName(VirtualKeyCode.OEM_2, "OEM 2");
            AddKeyName(VirtualKeyCode.OEM_3, "OEM 3");
            AddKeyName(VirtualKeyCode.OEM_4, "OEM 4");
            AddKeyName(VirtualKeyCode.OEM_5, "OEM 5");
            AddKeyName(VirtualKeyCode.OEM_6, "OEM 6");
            AddKeyName(VirtualKeyCode.OEM_7, "OEM 7");
            AddKeyName(VirtualKeyCode.OEM_8, "OEM 8");
            AddKeyName(VirtualKeyCode.OEM_102, "OEM 102");
            AddKeyName(VirtualKeyCode.PROCESSKEY, "Process Key");
            AddKeyName(VirtualKeyCode.PACKET, "Packet");
            AddKeyName(VirtualKeyCode.ATTN, "Attn");
            AddKeyName(VirtualKeyCode.CRSEL, "CrSel");
            AddKeyName(VirtualKeyCode.EXSEL, "ExSel");
            AddKeyName(VirtualKeyCode.EREOF, "Erase EOF");
            AddKeyName(VirtualKeyCode.PLAY, "Play");
            AddKeyName(VirtualKeyCode.ZOOM, "Zoom");
            AddKeyName(VirtualKeyCode.NONAME, "No Name");
            AddKeyName(VirtualKeyCode.PA1, "PA1");
            AddKeyName(VirtualKeyCode.OEM_CLEAR, "Clear");
        }

        private static void AddKeyName(VirtualKeyCode key, string value)
        {
            if (!KeyNamesDict.ContainsKey(key))
            {
                KeyNamesDict.Add(key, value);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"Duplicate key found in KeyNames: {key}");
            }
        }
    }
}