using System.Runtime.InteropServices;

namespace AutoGUI.SendInput
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct INPUT
    {
        internal InputEvent type;
        internal InputUnion U;

        internal static int Size
        {
            get => Marshal.SizeOf(typeof(INPUT));
        }
    }
}
