using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    public class OpeningFilter: Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            return opening(bitmap);
        }
        private Bitmap opening(Bitmap bitmap)
        {
            MyImage myImage = new MyImage(bitmap);
            myImage.AddFilter(new ErosionFilter());
            myImage.AddFilter(new DilationFilter());

            return myImage.currentImg;
        }
    }
}
