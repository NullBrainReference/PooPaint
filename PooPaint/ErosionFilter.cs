using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    public class ErosionFilter: Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            return Erosion(bitmap);
        }
        private Bitmap Erosion(Bitmap bitmap)
        {
            Bitmap rez = new Bitmap(bitmap);
            int cube = 3;

            for (int i = 0; i < rez.Width; i++)
                for (int j = 0; j < rez.Height; j++)
                    rez.SetPixel(i, j, Color.White);
            for (int i = cube/2; i < rez.Width-cube/2; i++)
                for (int j = cube/2; j < rez.Height-cube/2; j++)
                {
                    bool isDirty = true;
                    for (int x = -cube / 2; x < cube / 2; x++)
                        for (int y = -cube / 2; y < cube / 2; y++)
                            if ((bitmap.GetPixel(i + x, j + y).R + bitmap.GetPixel(i + x, j + y).G + bitmap.GetPixel(i + x, j + y).B) / 3 > 0)
                            {
                                isDirty = false;
                                break;
                            }
                    if (isDirty) 
                        rez.SetPixel(i, j, Color.Black);
                }
            return rez;
        }
        private Bitmap AltErosion(Bitmap bitmap)
        {
            Bitmap BMPin = new Bitmap(bitmap);

            Color color = new Color();

            int Height = BMPin.Height;
            int Width = BMPin.Width;
            Bitmap BMPout = new Bitmap(Width, Height);
            int P = 255 / 2;
            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    color = BMPin.GetPixel(i, j);
                    int mean = (color.R + color.G + color.B) / 3;
                    BMPout.SetPixel(i, j, mean <= P ? Color.Black : Color.White);
                }
            }

            int[,,] BmpOUT = new int[3, Width, Height];

            byte[,,] ArRGB_IN = BMPadapter.ConvertToArray(BMPout, Width, Height);
            for (int y = 1; y < Height - 1; ++y)
            {
                for (int x = 1; x < Width - 1; ++x)
                {
                    int Li = x - 1;
                    int Ri = x + 1;
                    int Ly = y - 1;
                    int Ry = y + 1;
                    bool EditMask = false;

                    for (int x1 = Li; x1 < Ri + 1; x1++)
                    {
                        for (int y1 = Ly; y1 < Ry; y1++)
                        {
                            if (ArRGB_IN[0, x1, y1] < 255)
                            {
                                EditMask = true;
                            }
                        }
                    }

                    if (EditMask == true)
                    {
                        BmpOUT[0, x, y] = 0;
                        BmpOUT[1, x, y] = 0;
                        BmpOUT[2, x, y] = 0;
                    }
                    else
                    {
                        BmpOUT[0, x, y] = 255;
                        BmpOUT[1, x, y] = 255;
                        BmpOUT[2, x, y] = 255;
                    }
                    EditMask = false;
                }
            }
            return BMPadapter.ConvertToBmp(BmpOUT, Width, Height);
        }
    }
}
