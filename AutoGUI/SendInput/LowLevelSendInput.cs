using System.Runtime.InteropServices;

namespace AutoGUI.SendInput
{
    internal static class LowLevelSendInput
    {
        [DllImport("user32.dll")] public static extern uint SendInput(int lengthOfArray, INPUT[] pInputs, int cbSize);
    }
}
