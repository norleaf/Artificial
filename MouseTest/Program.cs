using ArtificialIntelligence;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Screen.GetBounds(null);
            Mouse.Click(new Point(2560 / 2, 1440 / 2));
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
           
      //      var screenHelper = new ScreenShotHelper();
      //      var shot = screenHelper.ScreenShot();
      //      
      //
      //      var pixel = screenHelper.GetFirstPixel(shot, Color.Red);
      //
      //      if(pixel.HasValue)
      //      {
      //          Console.WriteLine(pixel.Value.X);
      //          Console.WriteLine(pixel.Value.Y);
      //      }
      //      
      //      Console.Read();
        }

        void rotate(Bitmap shot)
        {
            Bitmap destination = new Bitmap(200, 200);
            using (var g = Graphics.FromImage(destination))
            {
                Matrix rot = new Matrix();
                rot.Rotate(30);
                g.Transform = rot;
                g.DrawImage(shot, 0, 0, 200, 200);
            }
        }
    }
}
