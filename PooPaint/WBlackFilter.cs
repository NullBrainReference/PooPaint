using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    public class WBlackFilter: Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            return WhiteBlackV2(bitmap);
        }
        private Bitmap WhiteBlackV2(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            int midColor = BMPadapter.getMediumColorValue(bitmap);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    int curColor = (bitmap.GetPixel(i, j).R + bitmap.GetPixel(i, j).G + bitmap.GetPixel(i, j).B);
                    if (curColor < midColor) result.SetPixel(i, j, Color.Black);
                    else result.SetPixel(i, j, Color.White);
                }
            }
            return result;
        }
    }
}
