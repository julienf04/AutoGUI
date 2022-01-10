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
        /// Sets a specified key / Simulates to touch a specified key
        /// </summary>
        /// <param name="key">Key to set</param>
        public static void Set(VirtualKeyShort key)
        {
            INPUT input = new INPUT()
            {
                type = E_InputEvents.InputKeyboard,
                U = new InputUnion()
                {
                    ki = new KEYBDINPUT()
                    {
                        wVk = key
                    }
                }
            };

            LowLevelSendInput.SendInput(1, input, INPUT.Size);
        }

        /// <summary>
        /// Set a specified Unicode char / Simulates to print a specified Unicode char
        /// </summary>
        /// <param name="c">Char to set / Char to print</param>
        public static void Set(char c)
        {
            INPUT input = new INPUT()
            {
                type = E_InputEvents.InputKeyboard,
                U = new InputUnion()
                {
                    ki = new KEYBDINPUT()
                    {
                        dwFlags = KEYEVENTF.UNICODE,
                        wVk = 0,
                        wScan = (ScanCodeShort)c
                    }
                }
            };

            LowLevelSendInput.SendInput(1, input, INPUT.Size);
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
