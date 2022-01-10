using System.Runtime.InteropServices;
using AutoGUI.SendInput.KeyboardInput;
using AutoGUI.SendInput.MouseInput;
using AutoGUI.SendInput.HardwareInput;

namespace AutoGUI.SendInput
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct InputUnion
    {
        [FieldOffset(0)]
        internal MOUSEINPUT mi;
        [FieldOffset(0)]
        internal KEYBDINPUT ki;
        [FieldOffset(0)]
        internal HARDWAREINPUT hi;
    }
}
