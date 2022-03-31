using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    public class MedianFilter: Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            return Median(bitmap);
        }
        private Bitmap Median(Bitmap bitmap)
        {
            Bitmap rez = new Bitmap(bitmap);
            int cube = 3;
            for (int i = 0; i < bitmap.Width - cube; i++)
            {
                for (int j = 0; j < bitmap.Height - cube; j++)
                {
                    int[][] pixelColors = new int[cube * cube][];
                    int index = 0;
                    for (int x = 0; x < cube; x++)
                        for (int y = 0; y < cube; y++)
                        {
                            pixelColors[index] = new int[3] 
                            {bitmap.GetPixel(i+x,j+y).R,bitmap.GetPixel(i+x,j+y).G,bitmap.GetPixel(i+x,j+y).B};
                            index++;
                        }
                    for (int x = 0; x < index-1; x++)
                        for (int y = x+1; y < index; y++)
                        {
                            if (pixelColors[x][0] > pixelColors[y][0])
                            {
                                int tmp = pixelColors[x][0];
                                pixelColors[x][0] = pixelColors[y][0];
                                pixelColors[y][0] = tmp;
                            }
                            if (pixelColors[x][1] > pixelColors[y][1])
                            {
                                int tmp = pixelColors[x][0];
                                pixelColors[x][1] = pixelColors[y][1];
                                pixelColors[y][1] = tmp;
                            }
                            if (pixelColors[x][2] > pixelColors[y][2])
                            {
                                int tmp = pixelColors[x][2];
                                pixelColors[x][2] = pixelColors[y][2];
                                pixelColors[y][2] = tmp;
                            }
                        }
                    rez.SetPixel(i + cube / 2, j + cube / 2, Color.FromArgb(
                        pixelColors[index / 2][0], pixelColors[index / 2][1], pixelColors[index / 2][2]));
                }
            }
            return rez;
        }
    }
}
