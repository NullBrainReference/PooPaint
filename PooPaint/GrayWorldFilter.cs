using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    public class GrayWorldFilter: Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            return grayWorld(bitmap);
        }
        private Bitmap grayWorld(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap);
            int r = 0, g = 0, b = 0;
            int pixelCount = bitmap.Width * bitmap.Height;

            for(int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    r += bitmap.GetPixel(i, j).R;
                    g += bitmap.GetPixel(i, j).G;
                    b += bitmap.GetPixel(i, j).B;
                }
            }
            int xR = Convert.ToInt32(r / pixelCount);
            int xG = Convert.ToInt32(g / pixelCount);
            int xB = Convert.ToInt32(b / pixelCount);
            int avg = (xR + xG + xB) / 3;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    r = bitmap.GetPixel(i, j).R * avg / xR;
                    if (r > 255) r = 255;
                    g = bitmap.GetPixel(i, j).G * avg / xG;
                    if (g > 255) g = 255;
                    b = bitmap.GetPixel(i, j).B * avg / xB;
                    if (b > 255) b = 255;

                    result.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            return result;
        }
    }
}
