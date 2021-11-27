using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RectangleEnumApp.Model
{
    



    class Rectangle
    {
        private int _width;
        private int _height;
        private ColorType _borderColor = ColorType.RED;

        public Rectangle(int width , int height  )
        {
            _width = width;
            _height = height;
        }



        public int Width
        {
            set
            {
                if (value < 100)
                {
                    _width = value;
                }
                else
                {
                    _width = 100;
                }
            }

            get
            {
                return _width;
            }

        }

        public int Height
        {
            set
            {
                if (value < 100)
                {
                    _height = value;
                }
                else
                {
                    _height = 100;
                }
            }

            get
            {
                return _height;
            }

        }



        public int CalculateArea
        {
            get
            {
                return _width * _height;
            }
        }



        public ColorType BorderColor
        {
            set
            {
                _borderColor = value;
            }

            get
            {
                return _borderColor;
            }
           
        }

        
            
    }
}
