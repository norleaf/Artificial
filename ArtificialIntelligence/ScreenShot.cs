using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtificialIntelligence
{
    public class ScreenShotHelper
    {
        public Bitmap ScreenShot()
        {
            var screenShot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                        Screen.PrimaryScreen.Bounds.Height,
                                        PixelFormat.Format32bppArgb);

            using (var g = Graphics.FromImage(screenShot))
            {
                g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
            }

            return screenShot;
        }

        public Point? GetFirstPixel(Bitmap bitmap, Color targetcolor)
        {
            Console.WriteLine(string.Format("bitmpap height {0}",bitmap.Height));
            

            for (var y = 0; y < bitmap.Height; y+=2)
            {
                for (var x = 0; x < bitmap.Width; x+=2)
                {
                    Color color = bitmap.GetPixel(x, y);
                    if (color.R > 240)
                    {
                        return new Point(x, y);
                    }
                    //else 
                    //{
                    //    Console.WriteLine(color.R);
                    //}
                }
            }

            return null;
        }

        public bool ClickOnFirstPixel(Color color)
        {
            var pt = GetFirstPixel(ScreenShot(), color);

            if (pt.HasValue)
            {
                Mouse.Click(pt.Value);
            }

            // return whether found pixel and clicked it
            return pt.HasValue;
        }

    }

    
}
