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

        public Point? GetFirstPixel(Bitmap bitmap, Color color)
        {
            for (var y = 0; y < bitmap.Height; y++)
            {
                for (var x = 0; x < bitmap.Width; x++)
                {
                    if (bitmap.GetPixel(x, y).Equals(color))
                    {
                        return new Point(x, y);
                    }
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
