using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEncapsulationApp.Model
{
    class Circle
    {
        private float _radius ;
        private String _borderColor ;
        private String _fillColor;
        



        public void SetRadius(float radius)
        {
            if (0 < radius && radius > 11)
            {
                radius = 1.0f;

            }

            _radius = radius;

            
        }

        public void SetBorderColor(String borderColor)
        {
            if (borderColor != "red" && borderColor != "blue" && borderColor != "green")
            {
                Console.WriteLine("Invalid color");
            }
            else
            {
                _borderColor = borderColor;
            }

           
        }


        public void SetFillColor(String fillColor)
        {
            if (fillColor != "red" && fillColor != "blue" && fillColor != "green")
            {
                Console.WriteLine("Invalid color");

            }
            else
            {
                _fillColor = fillColor;
            }

            


        }

        public float GetRadius()
        {
            return _radius;
        }

        public String GetBorderColor()
        {
            return _borderColor;
        }

        public String GetFillColor()
        {
            return _fillColor;
        }

        public float CalculateArea()
        {
            return 3.14f * _radius * _radius;
        }
    }
}
