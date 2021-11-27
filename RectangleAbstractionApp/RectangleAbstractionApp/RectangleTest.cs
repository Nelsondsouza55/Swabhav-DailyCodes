using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleAbstractionApp.ModelApp;


namespace RectangleAbstractionApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle small;
            small = new Rectangle();
            small.width = 10;
            small.height = 6;
            small.CalculateArea();

            Rectangle big;
            big = new Rectangle();
            big.width = 120;
            big.height = 80;
            big.CalculateArea();


            Console.WriteLine("Big Width " + big.width + " Big Height " + big.height + " Big Area " + big.CalculateArea());
            Console.WriteLine("Small Width " + small.width+ " Small Height " +small.height+ " Small Area " +small.CalculateArea());
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Rectangle temp = small;
            Console.WriteLine(temp.width);
            Console.WriteLine(small.width);
            temp.width = temp.width + 7;
            Console.WriteLine(temp.width);
            Console.WriteLine(small.width);

            Console.WriteLine(small.GetHashCode());
            Console.WriteLine(big.GetHashCode());
            Console.WriteLine(temp.GetHashCode());


            Console.ReadKey();
        }
    }
}
