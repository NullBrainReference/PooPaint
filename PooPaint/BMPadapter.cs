using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace PooPaint
{
    public static class BMPadapter
    {
        public static byte[,,] ConvertToArray(Bitmap BMPin, int width, int height)
        {

            byte[,,] ArRGB_IN = new byte[3, width, height];
            for (int j = 0; j < height; ++j)
            {
                for (int i = 0; i < width; ++i)
                {
                    Color color = BMPin.GetPixel(i, j);
                    ArRGB_IN[0, i, j] = color.R;
                    ArRGB_IN[1, i, j] = color.G;
                    ArRGB_IN[2, i, j] = color.B;
                }
            }
            return ArRGB_IN;
        }
        public static Bitmap ConvertToBmp(int[,,] ArrIN, int width, int height)
        {

            Bitmap result = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    result.SetPixel(i, j, Color.FromArgb(ArrIN[0, i, j], ArrIN[1, i, j], ArrIN[2, i, j]));
                }
            }
            return result;
        }
        public static int getMediumColorValue(Bitmap bitmap)
        {
            int midColor = 0;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    midColor += (bitmap.GetPixel(i, j).R + bitmap.GetPixel(i, j).G + bitmap.GetPixel(i, j).B);
                }
            }
            midColor /= (bitmap.Width * bitmap.Height);
            return midColor;
        }

    }
}
