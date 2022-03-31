using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    public class CannyFilter : Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            Bitmap rez = new Bitmap(bitmap);
            rez = Canny.MakeGrayscale(rez);
            Filter blur = new BlurFilter();
            rez = blur.Use(rez);
            rez = Canny.DetectEdge(rez);
            return rez;
        }
    }
}
