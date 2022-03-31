using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    public class SharpnessFilter: Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            return Sharpnes(bitmap);
        }
        private Bitmap Sharpnes(Bitmap bitmap)
        {
            int width = bitmap.Width,
                height = bitmap.Height;
            byte[,,] ArRGB_IN = BMPadapter.ConvertToArray(bitmap, width, height);
            int[,,] BmpOUT = new int[3, bitmap.Width, bitmap.Height];

            double[,] bcore = new double[3, 3] { { -0.1, -0.1, -0.1 }, { -0.1, 1.8, -0.1 }, { -0.1, -0.1, -0.1 } };

            for (int i = 0; i < width; ++i)
            {
                for (int j = 0; j < height; ++j)
                {
                    double red = 0, green = 0, blue = 0;
                    for (int k = -1; k <= 1; k++)
                    {
                        for (int p = -1; p <= 1; p++)
                        {
                            int iX = i + k;
                            int iY = j + p;

                            if (iX < 0) iX = 0;
                            if (iY < 0) iY = 0;
                            if (iX >= width) iX = i;
                            if (iY >= height) iY = j;

                            red += (ArRGB_IN[0, iX, iY] * bcore[k + 1, p + 1]);
                            green += (ArRGB_IN[1, iX, iY] * bcore[k + 1, p + 1]);
                            blue += (ArRGB_IN[2, iX, iY] * bcore[k + 1, p + 1]);

                        }
                    }

                    if (red < 0) red = 0;
                    if (red > 255) red = 255;

                    if (green < 0) green = 0;
                    if (green > 255) green = 255;

                    if (blue < 0) blue = 0;
                    if (blue > 255) blue = 255;

                    //запись
                    BmpOUT[0, i, j] = (int)red;
                    BmpOUT[1, i, j] = (int)green;
                    BmpOUT[2, i, j] = (int)blue;
                }
            }
            bitmap = BMPadapter.ConvertToBmp(BmpOUT, bitmap.Width, bitmap.Height);
            return bitmap;
        }
    }
}
