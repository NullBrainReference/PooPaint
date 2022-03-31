using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPaint
{
    public class ClosingFilter: Filter
    {
        public override Bitmap Use(Bitmap bitmap)
        {
            return Closing(bitmap);
        }
        private Bitmap Closing(Bitmap bitmap)
        {
            MyImage myImage = new MyImage(bitmap);
            myImage.AddFilter(new DilationFilter());
            myImage.AddFilter(new ErosionFilter());

            return myImage.currentImg;
        } 

       
    }
}
