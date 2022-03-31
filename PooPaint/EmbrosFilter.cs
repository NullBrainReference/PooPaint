using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    public class EmbrosFilter: Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            return Embross(bitmap);
        }
        private Bitmap Embross(Bitmap bmp)
        {
            int width = bmp.Width,
                height = bmp.Height;
            int[,,] BmpOUT = new int[3, width, height]; ;

            byte[,,] ArRGB_IN = BMPadapter.ConvertToArray(bmp, width, height);


            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    int xx = x + 1; if (xx == width) xx = x;
                    int yy = y + 1; if (yy == height) yy = y;
                    for (int z = 0; z < 3; ++z)
                        BmpOUT[z, x, y] = Math.Min(Math.Abs(ArRGB_IN[0, x, y] - ArRGB_IN[0, xx, yy] + 128), 255);
                }
            }
            return BMPadapter.ConvertToBmp(BmpOUT, width, height);
        }
    }
}
