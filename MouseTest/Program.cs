using ArtificialIntelligence;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var screenHelper = new ScreenShotHelper();
            var shot = screenHelper.ScreenShot();
            

            var pixel = screenHelper.GetFirstPixel(shot, Color.Red);

            if(pixel.HasValue)
            {
                Console.WriteLine(pixel.Value.X);
                Console.WriteLine(pixel.Value.Y);
            }
            
            Console.Read();
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
