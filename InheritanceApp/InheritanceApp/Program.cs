using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InheritanceApp.Model;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            // CaseStudy4();
            CaseStudy5();
            Console.ReadLine();
        }

        public static void CaseStudy1()
        {
            Man x = new Man();
            x.Walk();
            x.Play();
            x.Read();
        }

        public static void CaseStudy2()
        {
            Boy y;
            y = new Boy();
            y.Play();
            y.Jump();
            y.Read();
            y.Walk();
            

        }

        public static void CaseStudy3()
        {
            Man x;
            x = new Boy();
            x.Read();
            x.Play();
            x.Walk();

        }

        public static void CaseStudy4()
        {
            AtThePark(new Man());

            AtThePark(new Boy());

            AtThePark(new Kid());

            AtThePark(new Infant());
        }

        public static void AtThePark(Man x)
        {
            Console.WriteLine("At the park");
            Console.WriteLine("");
            x.Play();
        }


        public static void CaseStudy5()
        {
            Object x;
            x = 10;
            Console.WriteLine(x.GetType());
            x = "Hello World";
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());
        }
    }
}
