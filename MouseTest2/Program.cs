using ArtificialIntelligence;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseTest2
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
            var random = new Random();
            for (int i = 0; i < 250; i++)
            {
                int x = 0, y = 0;
                for (int j = 0; j < 10; j++)
                {
                    x += random.Next(214);
                    y += random.Next(140);
                }
                Mouse.Click(new Point(x, y));
                Thread.Sleep(1);
            };
        }

        void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
