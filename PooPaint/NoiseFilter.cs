using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    public class NoiseFilter: Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            return Noize(bitmap);
        }
        private Bitmap Noize(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap);
            Random rnd = new Random();
            const double probabilityWhite = 0.1; //вероятность зашумления белым цветом
            const double probabilityGrey = 0; // вероятность зашумления серым цветом


            for (int y = 0; y < bitmap.Height; ++y)
            {
                for (int x = 0; x < bitmap.Width; ++x)
                {
                    double randValue = rnd.NextDouble(); // случ число в диапазоне 0 - 1

                    if (randValue < probabilityWhite)
                    {
                        result.SetPixel(x,y, Color.FromArgb(255,255,255));

                    }
                    else if (randValue < probabilityWhite + probabilityGrey)
                    {
                        result.SetPixel(x, y, Color.FromArgb(192, 192, 192));
                    }
                    else
                    {
                        result.SetPixel(x, y, bitmap.GetPixel(x, y));
                    }
                }
            }
            return result;

        }
    }
}
