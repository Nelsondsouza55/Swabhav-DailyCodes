using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleEnumApp.Model;

namespace RectangleEnumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(0,0);
            
            r1.Width = 101;
            r1.Height = 20;
            r1.BorderColor = ColorType.BLUE;
            PrintDetails(r1);

            Console.ReadLine();

        }


        public static void PrintDetails(Rectangle r)
        {
            Console.WriteLine("The width is {0}" , r.Width );
            Console.WriteLine("The height is {0}", r.Height);
            Console.WriteLine("The border color is {0}", r.BorderColor);
        }
    }
}
