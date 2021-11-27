using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleConstructorApp.Model;

namespace RectangleConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(50, 50, "blue" , "green");
            PrintDetails(r1);
            Console.WriteLine("");
            CaseStudy1();
            Console.ReadLine();


        }


        public static void CaseStudy1()
        {
            Rectangle r1 = new Rectangle(100, 50, "red");
            PrintDetails(r1);
        }

        public static void PrintDetails(Rectangle r)
        {
            Console.WriteLine("The width is " +r.GetWidth());
            Console.WriteLine("The height is " + r.GetHeight());
            Console.WriteLine("The color is " + r.GetColor());
            Console.WriteLine("The border color is " + r.GetBorderColor());

        }
    }
}
