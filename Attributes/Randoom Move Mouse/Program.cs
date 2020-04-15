using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Randoom_Move_Mouse
{
    public class Program
    {
        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y);

        static void Main(string[] args)
        {
            var rnd = new Random();

            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine("Where is the mouse .... :D ?");
                SetCursorPos(rnd.Next(0, 2000), rnd.Next(0, 2000));
                Thread.Sleep(300);
                Console.Beep(300, 100);
            }
        }
    }
}
