using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    public class RandomDitheringFilter: Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            MyImage myImage = new MyImage(bitmap);
            myImage.AddFilter(new NoiseFilter());
            myImage.AddFilter(new WBlackFilter());


            return myImage.currentImg;
            //return randomDithering(bitmap);
        }
        private Bitmap randomDithering(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Random rnd = new Random();
                    double pixelColor = (0.299 * bitmap.GetPixel(i, j).R + 0.587 * bitmap.GetPixel(i, j).G + 0.114 * bitmap.GetPixel(i, j).B);
                    if (pixelColor > rnd.Next(0, 255)) result.SetPixel(i, j, Color.White);
                    else result.SetPixel(i, j, Color.Black);
                }
            }

            return result;
        }
    }
}
