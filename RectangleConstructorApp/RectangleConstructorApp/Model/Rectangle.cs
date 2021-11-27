using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp.Model
{

    class Rectangle
    {
        private readonly int _width;
        private readonly int _height;
        private readonly String _color;
        private readonly String _borderColor;

        public Rectangle(int width, int height, String color)
        {
            _width = width;
            _height = height;
            _color = color;

        }

        public Rectangle(int width, int height, String color, String borderColor)
        {
            _width = width;
            _height = height;
            _color = color;
            _borderColor = borderColor;

        }

            public int GetWidth()
            {
                return _width;
            }

            public int GetHeight()
            {
                return _height;
            }

            public String GetColor()
            {
                return _color;
            }

            public String GetBorderColor()
             {
            return _borderColor;
             }

        public int GetArea()
            {
                return _width * _height;
            }
        
    }
}
