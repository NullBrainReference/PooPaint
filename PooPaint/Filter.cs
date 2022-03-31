using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PooPaint
{
    public class Filter
    {
        public double[,] core;
        public Filter()
        {
            core = new double[3, 3] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };

        }
        public Filter(double a11, double a12, double a13, double a21, double a22, double a23, double a31, double a32, double a33)
        {
            core = new double[3, 3] { { a11, a12, a13 }, { a21, a22, a23 }, { a31, a32, a33 } };
        }
        public Filter(string a11, string a12, string a13, string a21, string a22, string a23, string a31, string a32, string a33)
        {
            core = new double[3, 3] {
                { Convert.ToDouble(a11), Convert.ToDouble(a12), Convert.ToDouble(a13) },
                { Convert.ToDouble(a21), Convert.ToDouble(a22), Convert.ToDouble(a23) },
                { Convert.ToDouble(a31), Convert.ToDouble(a32), Convert.ToDouble(a33) }
            };
        }
        public virtual Bitmap Use(Bitmap bitmap)
        {
            return MainFilter(bitmap);
        }

        private Bitmap MainFilter(Bitmap bitmap)
        {
            int width = bitmap.Width,
                height = bitmap.Height;
            byte[,,] ArRGB_IN = BMPadapter.ConvertToArray(bitmap, width, height);
            int[,,] BmpOUT = new int[3, bitmap.Width, bitmap.Height];

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

                            red += (ArRGB_IN[0, iX, iY] * core[k + 1, p + 1]);
                            green += (ArRGB_IN[1, iX, iY] * core[k + 1, p + 1]);
                            blue += (ArRGB_IN[2, iX, iY] * core[k + 1, p + 1]);
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
        //public static Bitmap BlureV2(Bitmap bitmap)
        //{
        //    int width = bitmap.Width,
        //        height = bitmap.Height;
        //    byte[,,] ArRGB_IN = BMPadapter.ConvertToArray(bitmap, width, height);
        //    int[,,] BmpOUT = new int[3, bitmap.Width, bitmap.Height];
        //
        //    double[,] bcore = new double[3, 3] { { 0.1, 0.1, 0.1 }, { 0.1, 0.2, 0.1 }, { 0.1, 0.1, 0.1 } };
        //
        //    for (int i = 0; i < width; ++i)
        //    {
        //        for (int j = 0; j < height; ++j)
        //        {
        //            double red = 0, green = 0, blue = 0;
        //            for (int k = -1; k <= 1; k++)
        //            {
        //                for (int p = -1; p <= 1; p++)
        //                {
        //                    int iX = i + k;
        //                    int iY = j + p;
        //
        //                    if (iX < 0) iX = 0;
        //                    if (iY < 0) iY = 0;
        //                    if (iX >= width) iX = i;
        //                    if (iY >= height) iY = j;
        //
        //                    red += (ArRGB_IN[0, iX, iY] * bcore[k + 1, p + 1]);
        //                    green += (ArRGB_IN[1, iX, iY] * bcore[k + 1, p + 1]);
        //                    blue += (ArRGB_IN[2, iX, iY] * bcore[k + 1, p + 1]);
        //
        //                    //sum += bcore[k + 1, p + 1];
        //                }
        //            }
        //            //if (sum <= 0) sum = 1;
        //
        //            //red /= sum;
        //            if (red < 0) red = 0;
        //            if (red > 255) red = 255;
        //
        //            //green /= sum;
        //            if (green < 0) green = 0;
        //            if (green > 255) green = 255;
        //
        //            //blue /= sum;
        //            if (blue < 0) blue = 0;
        //            if (blue > 255) blue = 255;
        //
        //            //запись
        //            BmpOUT[0, i, j] = (int)red;
        //            BmpOUT[1, i, j] = (int)green;
        //            BmpOUT[2, i, j] = (int)blue;
        //        }
        //    }
        //    bitmap = BMPadapter.ConvertToBmp(BmpOUT, bitmap.Width, bitmap.Height);
        //    return bitmap;
        //}
        //public static Bitmap Sharpnes(Bitmap bitmap)
        //{
        //    int width = bitmap.Width,
        //        height = bitmap.Height;
        //    byte[,,] ArRGB_IN = BMPadapter.ConvertToArray(bitmap, width, height);
        //    int[,,] BmpOUT = new int[3, bitmap.Width, bitmap.Height];
        //
        //    double[,] bcore = new double[3, 3] { { -0.1, -0.1, -0.1 }, { -0.1, 1.8, -0.1 }, { -0.1, -0.1, -0.1 } };
        //
        //    for (int i = 0; i < width; ++i)
        //    {
        //        for (int j = 0; j < height; ++j)
        //        {
        //            double red = 0, green = 0, blue = 0;
        //            for (int k = -1; k <= 1; k++)
        //            {
        //                for (int p = -1; p <= 1; p++)
        //                {
        //                    int iX = i + k;
        //                    int iY = j + p;
        //
        //                    if (iX < 0) iX = 0;
        //                    if (iY < 0) iY = 0;
        //                    if (iX >= width) iX = i;
        //                    if (iY >= height) iY = j;
        //
        //                    red += (ArRGB_IN[0, iX, iY] * bcore[k + 1, p + 1]);
        //                    green += (ArRGB_IN[1, iX, iY] * bcore[k + 1, p + 1]);
        //                    blue += (ArRGB_IN[2, iX, iY] * bcore[k + 1, p + 1]);
        //
        //                }
        //            }
        //
        //            if (red < 0) red = 0;
        //            if (red > 255) red = 255;
        //
        //            if (green < 0) green = 0;
        //            if (green > 255) green = 255;
        //
        //            if (blue < 0) blue = 0;
        //            if (blue > 255) blue = 255;
        //
        //            //запись
        //            BmpOUT[0, i, j] = (int)red;
        //            BmpOUT[1, i, j] = (int)green;
        //            BmpOUT[2, i, j] = (int)blue;
        //        }
        //    }
        //    bitmap = BMPadapter.ConvertToBmp(BmpOUT, bitmap.Width, bitmap.Height);
        //    return bitmap;
        //}
        //public static Bitmap Borders(Bitmap bitmap)
        //{
        //    int width = bitmap.Width,
        //        height = bitmap.Height;
        //    byte[,,] ArRGB_IN = BMPadapter.ConvertToArray(bitmap, width, height);
        //    int[,,] BmpOUT = new int[3, bitmap.Width, bitmap.Height];
        //
        //    double[,] bcore = new double[3, 3] { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };
        //
        //
        //    for (int i = 0; i < width; ++i)
        //    {
        //        for (int j = 0; j < height; ++j)
        //        {
        //            double red = 0, green = 0, blue = 0;
        //            for (int k = -1; k <= 1; k++)
        //            {
        //                for (int p = -1; p <= 1; p++)
        //                {
        //                    int iX = i + k;
        //                    int iY = j + p;
        //
        //                    if (iX < 0) iX = 0;
        //                    if (iY < 0) iY = 0;
        //                    if (iX >= width) iX = i;
        //                    if (iY >= height) iY = j;
        //
        //                    red += (ArRGB_IN[0, iX, iY] * bcore[k + 1, p + 1]);
        //                    green += (ArRGB_IN[1, iX, iY] * bcore[k + 1, p + 1]);
        //                    blue += (ArRGB_IN[2, iX, iY] * bcore[k + 1, p + 1]);
        //                }
        //            }
        //
        //            if (red < 0) red = 0;
        //            if (red > 255) red = 255;
        //
        //            if (green < 0) green = 0;
        //            if (green > 255) green = 255;
        //
        //            if (blue < 0) blue = 0;
        //            if (blue > 255) blue = 255;
        //
        //            //запись
        //            BmpOUT[0, i, j] = (int)red;
        //            BmpOUT[1, i, j] = (int)green;
        //            BmpOUT[2, i, j] = (int)blue;
        //        }
        //    }
        //    bitmap = BMPadapter.ConvertToBmp(BmpOUT, bitmap.Width, bitmap.Height);
        //    return bitmap;
        //}
        //public static Bitmap Embross(Bitmap bmp)
        //{
        //    int width = bmp.Width,
        //        height = bmp.Height;
        //    int[,,] BmpOUT = new int[3, width, height]; ;
        //
        //    byte[,,] ArRGB_IN = BMPadapter.ConvertToArray(bmp, width, height);
        //
        //
        //    for (int y = 0; y < height; ++y)
        //    {
        //        for (int x = 0; x < width; ++x)
        //        {
        //            int xx = x + 1; if (xx == width) xx = x;
        //            int yy = y + 1; if (yy == height) yy = y;
        //            for (int z = 0; z < 3; ++z)
        //                BmpOUT[z, x, y] = Math.Min(Math.Abs(ArRGB_IN[0, x, y] - ArRGB_IN[0, xx, yy] + 128), 255);
        //        }
        //    }
        //    return BMPadapter.ConvertToBmp(BmpOUT, width, height);
        //}
    }
}
