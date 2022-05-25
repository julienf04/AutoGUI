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
        /// INPUT instance
        /// </summary>
        private static INPUT[] _input = new INPUT[1]
        {
             new INPUT()
             {
                type = InputEvent.InputMouse,
                U = new InputUnion()
                {
                    mi = new MOUSEINPUT()
                }
             }
        };

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

        private static void _CursorEvent(MouseEvents mouseEvent, int mouseData = 0)
        {
            _input[0].U.mi.dwFlags = mouseEvent;
            _input[0].U.mi.mouseData = mouseData;

            LowLevelSendInput.SendInput(_input.Length, _input, INPUT.Size);
        }

        /// <summary>
        /// Simple left click
        /// </summary>
        public static void LeftClick()
        {
            LeftClickDown();
            LeftClickUp();
        }

        /// <summary>
        /// Simple right click
        /// </summary>
        public static void RightClick()
        {
            RightClickDown();
            RightClickUp();
        }

        /// <summary>
        /// Maintains left click pressed indefinitely
        /// </summary>
        public static void LeftClickDown() => _CursorEvent(MouseEvents.LEFTDOWN);

        /// <summary>
        /// Releases left click if it is being pressed
        /// </summary>
        public static void LeftClickUp() => _CursorEvent(MouseEvents.LEFTUP);

        /// <summary>
        /// Maintains right click pressed indefinitely
        /// </summary>
        public static void RightClickDown() => _CursorEvent(MouseEvents.RIGHTDOWN);

        /// <summary>
        /// Releases right click if it is being pressed
        /// </summary>
        public static void RightClickUp() => _CursorEvent(MouseEvents.RIGHTUP);

        /// <summary>
        /// Moves the vertical wheel of the mouse
        /// </summary>
        /// <param name="intensity">Amount of movement</param>
        public static void VerticalWheel(int intensity) => _CursorEvent(MouseEvents.WHEEL, intensity);

        /// <summary>
        /// Moves the horizontal wheel of the mouse
        /// </summary>
        /// <param name="intensity">Amount of movement</param>
        public static void HorizontalWheel(int intensity) => _CursorEvent(MouseEvents.HWHEEL, intensity);

    }
}
