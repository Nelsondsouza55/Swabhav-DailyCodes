using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AurionProMathCalculator;

namespace ConsoleAurionProMathCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.PrimeNoCheck(52));
            //calc.GenerateEvenNo(30);
            Console.WriteLine("");
            calc.GeneratePrime(10);
            Console.ReadLine();
        }
    }
}
