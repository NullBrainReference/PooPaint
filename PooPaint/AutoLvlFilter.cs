using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    public class AutoLvlFilter: Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            return autoLevel(bitmap);
        }

        private Bitmap autoLevel(Bitmap bitmap)
        {
            Bitmap rez = new Bitmap(bitmap);
            int maxR = 0, minR = 255;
            int maxG = 0, minG = 255;
            int maxB = 0, minB = 255;

            for (int i = 0; i < bitmap.Width; i++)
                for (int j = 0; j < bitmap.Height; j++)
                {
                    if (minR > bitmap.GetPixel(i, j).R) minR = bitmap.GetPixel(i, j).R;
                    if (maxR < bitmap.GetPixel(i, j).R) maxR = bitmap.GetPixel(i, j).R;

                    if (minG > bitmap.GetPixel(i, j).G) minG = bitmap.GetPixel(i, j).G;
                    if (maxG < bitmap.GetPixel(i, j).G) maxG = bitmap.GetPixel(i, j).G;

                    if (minB > bitmap.GetPixel(i, j).B) minB = bitmap.GetPixel(i, j).B;
                    if (maxB < bitmap.GetPixel(i, j).B) maxB = bitmap.GetPixel(i, j).B;
                }
            for (int i = 0; i < bitmap.Width; i++)
                for (int j = 0; j < bitmap.Height; j++)
                {
                    rez.SetPixel(i, j, Color.FromArgb(
                        (int)(double)((bitmap.GetPixel(i, j).R - minR) * (255.0 / (maxR - minR))),
                        (int)(double)((bitmap.GetPixel(i, j).G - minG) * (255.0 / (maxG - minG))),
                        (int)(double)((bitmap.GetPixel(i, j).B - minB) * (255.0 / (maxB - minB)))));
                }

            return rez;
        } 
    }
}
