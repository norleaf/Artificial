using ArtificialIntelligence;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseTest3
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
            Point point1 = new Point(450, 750);
            Point point2 = new Point(825, 750);
            Point center = new Point(960, 540);
            Point closeCharSheet = new Point(1400, 310);
            var a = new Point( 350,1060 );
            var b = new Point( 450,1060 );
            var c = new Point( 600,1060 );
            var d = new Point( 750,1060 );
            var e = new Point( 900,1060 );
            var f = new Point( 1050,1060 );
            var g = new Point( 1200,1060 );
            var h = new Point( 1350,1060 );
            var k = new Point( 1500,1060 );
            var l = new Point( 1650,1060 );
            var m = new Point( 1780,1060 );


            var points = new Point[] 
            {
                point1, closeCharSheet,
                point2, closeCharSheet,
               
                a,b,c,d,e,f,g,h,k,l,m
            };
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            Thread.Sleep(1000);

            }
            for (int i = 0; i < 100000; i++)
            {
               

                foreach (var point in points)
                {


                    Mouse.Click(point);
                    Console.WriteLine("clicked: "+point.X + "," + point.Y);
                    Thread.Sleep(50);
                }
                Cursor.Position = center;
                Thread.Sleep(10000);
            }


        }

        void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
