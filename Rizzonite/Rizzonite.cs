using System;
using System.Runtime.InteropServices;
using ResoniteModLoader;

namespace Rizzonite
{
    public class Rizzonite : ResoniteMod
    {
        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool SetWindowTextA(IntPtr hWnd, string lpString);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);


        internal const string VERSION_CONSTANT = "1.0.0";
        public override string Name => "Rizzonite";
        public override string Author => "Obi 1";
        public override string Version => VERSION_CONSTANT;
        public override string Link => "https://github.com/Obimydudee/Obis-Resonite-Mods/tree/main/Rizzonite";

        public override void OnEngineInit()
        {
            IntPtr hWnd = FindWindow(null, "Resonite");
            if (hWnd != IntPtr.Zero)
            {
                bool result = SetWindowTextA(hWnd, "Rizzonite");
                if (result) { Msg("Window title changed successfully!"); }
            }
        }
    }
}
