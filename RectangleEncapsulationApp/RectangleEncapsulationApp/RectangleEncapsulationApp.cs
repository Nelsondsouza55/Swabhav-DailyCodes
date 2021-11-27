using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleEncapsulationApp.Model;

namespace RectangleEncapsulationApp
{
    class RectangleEncapsulationApp
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle();
            small.SetWidth(-10);
            small.SetHeight(100);
            Console.WriteLine(small.GetWidth());
            Console.WriteLine(small.GetHeight());
            Console.ReadLine();

        }

    }
}
