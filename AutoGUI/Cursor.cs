using System.Runtime.InteropServices;
using AutoGUI.SendInput;
using AutoGUI.SendInput.MouseInput;

namespace AutoGUI
{
    /// <summary>
    /// Manages your cursor
    /// </summary>
    public static class Cursor
    {
        [DllImport("User32")] private static extern bool SetCursorPos(int X, int Y);
        [DllImport("User32")] private static extern bool GetCursorPos(out Point p);

        /// <summary>
        /// Sets the specified absolute position
        /// </summary>
        /// <param name="x">Position on X axis</param>
        /// <param name="y">Position on Y axis</param>
        public static void SetPos(int x, int y) => SetCursorPos(x, y);

        /// <summary>
        /// Gets the absolute position
        /// </summary>
        /// <returns>X and Y axis</returns>
        public static Point GetPos()
        {
            Point p;
            GetCursorPos(out p);
            return p;
        }

        private static void _Click(E_MouseEvents mouseEvent)
        {
            INPUT input = new INPUT()
            {
                type = E_InputEvents.InputMouse,
                U = new InputUnion()
                {
                    mi = new MOUSEINPUT()
                    {
                        dwFlags = mouseEvent
                    }
                }
            };

            LowLevelSendInput.SendInput(1, input, INPUT.Size);
        }

        /// <summary>
        /// Simple left click
        /// </summary>
        public static void LeftClick()
        {
            _Click(E_MouseEvents.LEFTDOWN);
            _Click(E_MouseEvents.LEFTUP);
        }

        /// <summary>
        /// Simple right click
        /// </summary>
        public static void RightClick()
        {
            _Click(E_MouseEvents.RIGHTDOWN);
            _Click(E_MouseEvents.RIGHTUP);
        }

        /// <summary>
        /// Maintains left click pressed indefinitely
        /// </summary>
        public static void LeftClickDown() => _Click(E_MouseEvents.LEFTDOWN);

        /// <summary>
        /// Releases left click if it is being pressed
        /// </summary>
        public static void LeftClickUp() => _Click(E_MouseEvents.LEFTUP);

        /// <summary>
        /// Maintains right click pressed indefinitely
        /// </summary>
        public static void RightClickDown() => _Click(E_MouseEvents.RIGHTDOWN);

        /// <summary>
        /// Releases right click if it is being pressed
        /// </summary>
        public static void RightClickUp() => _Click(E_MouseEvents.RIGHTUP);

    }
}
