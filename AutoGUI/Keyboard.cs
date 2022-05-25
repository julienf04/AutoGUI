using AutoGUI.SendInput;
using AutoGUI.SendInput.KeyboardInput;

namespace AutoGUI
{
    /// <summary>
    /// Manages your keyboard
    /// </summary>
    public static class Keyboard
    {
        /// <summary>
        /// INPUT instance
        /// </summary>
        private static INPUT[] _input = new INPUT[1]
        {
            new INPUT()
            {
                type = InputEvent.InputKeyboard,
                U = new InputUnion()
                {
                    ki = new KEYBDINPUT()
                }
            }
        };

        /// <summary>
        /// Sets a specified key / Simulates to touch a specified key
        /// </summary>
        /// <param name="key">Key to set</param>
        public static void Set(VirtualKeyShort key)
        {
            _input[0].U.ki.dwFlags = 0;
            _input[0].U.ki.wScan = 0;
            _input[0].U.ki.wVk = key;

            LowLevelSendInput.SendInput(1, _input, INPUT.Size);
        }

        /// <summary>
        /// Set a specified Unicode char / Simulates to print a specified Unicode char
        /// </summary>
        /// <param name="c">Char to set / Char to print</param>
        public static void Set(char c)
        {
            _input[0].U.ki.dwFlags = KEYEVENTF.UNICODE;
            _input[0].U.ki.wVk = 0;
            _input[0].U.ki.wScan = (ScanCodeShort)c;

            LowLevelSendInput.SendInput(1, _input, INPUT.Size);
        }

        /// <summary>
        /// Sets a specified Unicode string / Simulates to print a specified Unicode string
        /// </summary>
        /// <param name="msg">String to set / String to print</param>
        public static void Set(string msg)
        {
            foreach (char c in msg)
                Set(c);
        }
    }
}
