using ArtificialIntelligence;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            Mouse.Click(new Point(1540, 720));
        }

        void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
