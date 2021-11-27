using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountEncapsulationApp.Model;

namespace AccountEqualityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy2();
            Console.ReadLine();
        }

        public static void CaseStudy1()
        {
            Account acc1 = new Account("Nelson", 101, 10000);
            Console.WriteLine(acc1);
            Console.WriteLine(acc1.ToString());
        }

        public static void CaseStudy2()
        {
            Account acc1 = new Account("Nelson", 101, 10000);
            Account acc2 = new Account("Nelson", 101, 10000);
            Console.WriteLine(acc1.GetHashCode());
            Console.WriteLine(acc2.GetHashCode());
            Console.WriteLine(acc1 == acc2);
            Console.WriteLine(acc1.Equals(acc2));

        }
    }
}
