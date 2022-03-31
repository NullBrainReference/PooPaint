using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace PooPaint
{
    public class MyImage
    {
        public Bitmap originalImg;
        public Bitmap currentImg;
        public List<Filter> filters;

        public MyImage(Bitmap bitmap)
        {
            originalImg = new Bitmap(bitmap);
            currentImg = new Bitmap(bitmap);
            filters = new List<Filter> { };
        }
        public void LoadImg(Bitmap bitmap)
        {
            originalImg = new Bitmap(bitmap);
            currentImg = new Bitmap(bitmap);
            filters = new List<Filter> { };
        }
        public void UpdateFilters()
        {
            currentImg = originalImg;
            foreach(Filter f in filters)
            {
                currentImg = f.Use(currentImg);
            }
        }
        public void AddFilter(Filter filter)
        {
            filters.Add(filter);
            currentImg = filter.Use(currentImg);
        }
        public void RemoveLastFilter()
        {
            if(filters.Count > 0)
            filters.RemoveAt(filters.Count - 1);

            UpdateFilters();
        }
    }
}
