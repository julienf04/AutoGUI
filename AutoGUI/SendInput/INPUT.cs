using System.Runtime.InteropServices;

namespace AutoGUI.SendInput
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct INPUT
    {
        internal E_InputEvents type;
        internal InputUnion U;

        internal static int Size
        {
            get => Marshal.SizeOf(typeof(INPUT));
        }
    }
}
