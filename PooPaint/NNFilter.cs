using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    public class NNFilter:Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            return pictureReSize(2,bitmap);
        }
        private Bitmap pictureReSize(int scale, Bitmap bitmap)
        {
            Bitmap ResizedPic = new Bitmap(bitmap.Width * scale, bitmap.Height * scale);

            for (int i = 0; i < bitmap.Width * scale; i += scale)
            {
                for (int j = 0; j < bitmap.Height * scale; j += scale)
                {
                    Color color = Color.FromArgb(bitmap.GetPixel(i / scale, j / scale).ToArgb());

                    for (int subX = i; subX < i + scale; subX++)
                    {
                        for (int subY = j; subY < j + scale; subY++)
                            ResizedPic.SetPixel(subX, subY, color);
                    }
                }
            }
            return new Bitmap(ResizedPic, ResizedPic.Width, ResizedPic.Height);
        }
    }
}
