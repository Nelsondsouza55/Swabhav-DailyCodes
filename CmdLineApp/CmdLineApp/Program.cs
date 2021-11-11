using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdLineApp
{
    class Program
    {
        static int foo = 100;
        static void Main(string[] args)
        {
            Console.WriteLine(foo);
            PrintDetails(100);
            PrintDetails("Hello");
            PrintDetails('#');
            PrintDetails(100f);
            PrintDetails(true);
            PrintDetails(100.66);
            Console.ReadKey();







        }

        private static void PrintDetails(int content)
        {
            Console.WriteLine("Overload #1: integer");
            Console.WriteLine(content);
        }

        private static void PrintDetails(string content)
        {
            Console.WriteLine("Overload #2: string");
            Console.WriteLine(content);
        }

        private static void PrintDetails(double content)
        {
            Console.WriteLine("Overload #3: double");
            Console.WriteLine(content);
        }

        private static void PrintDetails( char content)
        {
            Console.WriteLine("Overload #4: char");
            Console.WriteLine(content);
        }

        private static void PrintDetails(Boolean content)
        {
            Console.WriteLine("Overload #5: bool");
            Console.WriteLine(content);
        }

        private static void PrintDetails(float content)
        {
            Console.WriteLine("Overload #6: float");
            Console.WriteLine(content);
        }
    }
}
