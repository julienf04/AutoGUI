using System.Runtime.InteropServices; 

namespace AutoGUI.SendInput.MouseInput
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct MOUSEINPUT
    {
        internal int dx;
        internal int dy;
        internal int mouseData;
        internal MouseEvents dwFlags;
        internal uint time;
        internal UIntPtr dwExtraInfo;
    }
}
