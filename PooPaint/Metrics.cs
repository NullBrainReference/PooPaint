using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PooPaint
{
    public class Metrics
    {
        public static string PSNR(Bitmap bitmap)
        {
            string rez = "";
            Bitmap bitmap2 = new Bitmap(bitmap);
            OpenFileDialog openFile = new OpenFileDialog
            {
                Title = "Choose picture"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
                bitmap2 = new Bitmap(Image.FromFile(openFile.FileName));
            int maxR = 0, maxG = 0, maxB = 0;
            int sumR = 0, sumG = 0, sumB = 0;
            int pixCount = bitmap.Width * bitmap.Height;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    sumR += Convert.ToInt32(Math.Pow(bitmap.GetPixel(i, j).R - bitmap2.GetPixel(i, j).R, 2));
                    if (maxR < bitmap.GetPixel(i, j).R) maxR = bitmap.GetPixel(i, j).R;
                    if (maxR < bitmap2.GetPixel(i, j).R) maxR = bitmap2.GetPixel(i, j).R;

                    sumG += Convert.ToInt32(Math.Pow(bitmap.GetPixel(i, j).G - bitmap2.GetPixel(i, j).G, 2));
                    if (maxG < bitmap.GetPixel(i, j).G) maxG = bitmap.GetPixel(i, j).G;
                    if (maxG < bitmap2.GetPixel(i, j).G) maxG = bitmap2.GetPixel(i, j).G;

                    sumB += Convert.ToInt32(Math.Pow(bitmap.GetPixel(i, j).B - bitmap2.GetPixel(i, j).B, 2));
                    if (maxB < bitmap.GetPixel(i, j).B) maxB = bitmap.GetPixel(i, j).B;
                    if (maxB < bitmap2.GetPixel(i, j).B) maxB = bitmap2.GetPixel(i, j).B;
                }
            }
            int MSE = (sumR / pixCount + sumG / pixCount + sumB / pixCount) / 3;
            int max = (maxR + maxG + maxB) / 3;
            double PSNR = 10 * Math.Log10(Math.Pow(max, 2) / MSE);
            rez = "MSE: " + MSE + "; PSNR: " + PSNR + "db";

            return rez;
        }
    }
}
