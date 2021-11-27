using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
        private int pwidth;
        private int pheight;


        public void SetWidth(int width)
        {

            if (width < 0)
            {
                width = 1;
            }

            else if (width > 100)
            {
                width = 100;
            }

            pwidth = width;
        }

        public void SetHeight(int height)
        {

            if (height < 0)
            {
                height = 1;
            }

            else if (height > 100)
            {
                height = 100;
            }

           pheight = height;
        }


        public int GetHeight()
        {
            return pheight;
        }

        public int GetWidth()
        {
            return pwidth;
        }
    }
}


           

