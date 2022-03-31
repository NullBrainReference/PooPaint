using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    public class MirrHFilter: Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            return HorizontalInvertation(bitmap);
        }
        private Bitmap HorizontalInvertation(Bitmap bitmap)
        {
            Bitmap rez = new Bitmap(bitmap);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    rez.SetPixel(bitmap.Width - i - 1, j, Color.FromArgb(bitmap.GetPixel(i, j).ToArgb()));
                }
            }
            return rez;
        }
    }
}
