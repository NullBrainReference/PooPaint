using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    class PsToneFilter:Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            return pseudoToning(bitmap);
        }
        private Bitmap pseudoToning(Bitmap bitmap)
        {
            Bitmap rez = new Bitmap(bitmap);

            int[][,] cMap = new int[16][,];
            cMap[0] = new int[4, 4] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            cMap[1] = new int[4, 4] { { 1, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 0 } };
            cMap[2] = new int[4, 4] { { 1, 0, 0, 0 }, { 0, 0, 0, 0 }, { 1, 0, 1, 0 }, { 0, 0, 0, 0 } };
            cMap[3] = new int[4, 4] { { 1, 0, 1, 0 }, { 0, 0, 0, 0 }, { 1, 0, 1, 0 }, { 0, 0, 0, 0 } };

            cMap[4] = new int[4, 4] { { 1, 0, 1, 0 }, { 0, 1, 0, 0 }, { 1, 0, 1, 0 }, { 0, 0, 0, 0 } };
            cMap[5] = new int[4, 4] { { 1, 0, 1, 0 }, { 0, 1, 0, 0 }, { 1, 0, 1, 0 }, { 0, 0, 0, 1 } };
            cMap[6] = new int[4, 4] { { 1, 0, 1, 0 }, { 0, 1, 0, 0 }, { 1, 0, 1, 0 }, { 0, 1, 0, 1 } };
            cMap[7] = new int[4, 4] { { 1, 0, 1, 0 }, { 0, 1, 0, 1 }, { 1, 0, 1, 0 }, { 0, 1, 0, 1 } };

            cMap[8] = new int[4, 4] { { 1, 1, 1, 0 }, { 0, 1, 0, 1 }, { 1, 0, 1, 0 }, { 0, 1, 0, 1 } };
            cMap[9] = new int[4, 4] { { 1, 1, 1, 0 }, { 0, 1, 0, 1 }, { 1, 0, 1, 1 }, { 0, 1, 0, 1 } };
            cMap[10] = new int[4, 4] { { 1, 1, 1, 1 }, { 0, 1, 0, 1 }, { 1, 0, 1, 1 }, { 0, 1, 0, 1 } };
            cMap[11] = new int[4, 4] { { 1, 1, 1, 1 }, { 0, 1, 0, 1 }, { 1, 1, 1, 1 }, { 0, 1, 0, 1 } };

            cMap[12] = new int[4, 4] { { 1, 1, 1, 1 }, { 1, 1, 0, 1 }, { 1, 1, 1, 1 }, { 0, 1, 0, 1 } };
            cMap[13] = new int[4, 4] { { 1, 1, 1, 1 }, { 1, 1, 0, 1 }, { 1, 1, 1, 1 }, { 0, 1, 0, 1 } };
            cMap[14] = new int[4, 4] { { 1, 1, 1, 1 }, { 1, 1, 0, 1 }, { 1, 1, 1, 1 }, { 0, 1, 1, 1 } };
            cMap[15] = new int[4, 4] { { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };

            for (int i = 0; i < bitmap.Width; i += 4)
            {
                for (int j = 0; j < bitmap.Height; j += 4)
                {
                    int colorSum = 0;
                    int counter = 0;
                    for (int x = i; x < i + 4; x++)
                    {
                        for (int y = j; y < j + 4; y++)
                        {
                            if (x < bitmap.Width && y < bitmap.Height)
                            {
                                colorSum += bitmap.GetPixel(x, y).R + bitmap.GetPixel(x, y).G + bitmap.GetPixel(x, y).B;
                                counter++;
                            }
                        }
                    }
                    colorSum /= 3;
                    colorSum /= 16;
                    colorSum /= counter;

                    for (int x = i; x < i + 4; x++)
                    {
                        for (int y = j; y < j + 4; y++)
                        {
                            if (x < bitmap.Width && y < bitmap.Height)
                            {
                                if (cMap[colorSum][Math.Abs(i - x), Math.Abs(j - y)] <= 0) rez.SetPixel(x, y, Color.Black);
                                else rez.SetPixel(x, y, Color.White);
                            }
                        }
                    }

                }
            }
            return rez;
        }
    }
}
