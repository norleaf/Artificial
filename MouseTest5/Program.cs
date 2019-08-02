using ArtificialIntelligence;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MouseTest4
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyApplicationContext());
        }
    }

    public class MyApplicationContext : ApplicationContext
    {
        public MyApplicationContext()
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);

            }

            Point point1 = new Point(1750, 340);
            Point point2 = new Point(1750, 500);
            Point point3 = new Point(1750, 660);
            Point point4 = new Point(960, 540);
            Point upgrade = new Point(200, 1060);

            for (int i = 0; i < 250; i++)
            {
                for (int j = 0; j < 200; j++)
                {
                    Mouse.Click(point1);
                    Thread.Sleep(20);
                    Mouse.Click(point2);
                    Thread.Sleep(20);
                    Mouse.Click(point3);
                    Thread.Sleep(20);
                }
                Mouse.Click(upgrade);
                Thread.Sleep(500);
                Mouse.Click(upgrade);
          //      Mouse.Click(point4);
                Thread.Sleep(3000);
            }



        }

        public delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        //Declare the hook handle as an int.
        static int hHook = 0;

        //Declare the mouse hook constant.
        //For other hook types, you can obtain these values from Winuser.h in the Microsoft SDK.
        public const int WH_MOUSE = 7;
        private System.Windows.Forms.Button button1;

        //Declare MouseHookProcedure as a HookProc type.
        HookProc MouseHookProcedure;

        //Declare the wrapper managed POINT class.
        [StructLayout(LayoutKind.Sequential)]
        public class POINT
        {
            public int x;
            public int y;
        }

        //Declare the wrapper managed MouseHookStruct class.
        [StructLayout(LayoutKind.Sequential)]
        public class MouseHookStruct
        {
            public POINT pt;
            public int hwnd;
            public int wHitTestCode;
            public int dwExtraInfo;
        }

        //This is the Import for the SetWindowsHookEx function.
        //Use this function to install a thread-specific hook.
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        //This is the Import for the UnhookWindowsHookEx function.
        //Call this function to uninstall the hook.
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        //This is the Import for the CallNextHookEx function.
        //Use this function to pass the hook information to the next hook procedure in chain.
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);

        void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
