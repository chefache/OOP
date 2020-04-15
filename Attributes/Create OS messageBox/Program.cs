using System;
using System.Runtime.InteropServices;

namespace Create_OS_messageBox
{
    class Program
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox")]

        public static extern int ShowMessageBox(int hWnd, string text, string caption, int type);

        static void Main(string[] args)
        {
            ShowMessageBox(0, "Hello Stefan", "My project", 1); // Possibla change of type 1, 2, 3...
        }
    }
}
