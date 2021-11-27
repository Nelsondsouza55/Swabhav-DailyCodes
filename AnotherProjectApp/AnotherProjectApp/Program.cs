using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AurionProMathCalculator;

namespace AnotherProjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            double num1 = 170;
            double num2 = 120;
            double result = calc.Addition(num1, num2);
            Console.Write(num1);
            Console.Write(" + ");
            Console.Write(num2);
            Console.Write(" = ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
