using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircleEncapsulationApp.Model;

namespace CircleEncapsulationApp
{
    class CircleEncapsulationApp
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            Console.ReadLine();
        }


        static void CaseStudy3()
        {
            Circle c1 = new Circle();
            c1.SetRadius(6);
            c1.SetFillColor("green");
            c1.SetBorderColor("red");

            Circle c2 = new Circle();
            c2.SetRadius(9);
            c2.SetFillColor("blue");
            c2.SetBorderColor("red");

            Circle[] manyCircles = new Circle[3];
            manyCircles[0] = c1;
            manyCircles[1] = new Circle();
            manyCircles[1].SetRadius(7);
            manyCircles[1].SetBorderColor("red");
            manyCircles[1].SetFillColor("blue");
            manyCircles[2] = c2;

            PrintDetails(manyCircles);
            PrintTheBiggestCircle(manyCircles);









        }


        static void CaseStudy2()
        {

            Console.WriteLine("Area of the anonymous circle is {0}",new Circle().CalculateArea());
            Console.WriteLine("Border color of the anonymous circle is {0}", new Circle().GetBorderColor());
            PrintDetails(new Circle());

        }
        static void CaseStudy1()
        {
            Circle c1 = new Circle();

            PrintDetails(c1);

            c1.SetRadius(5.5f);
            c1.SetBorderColor("blue");
            c1.SetFillColor("green");

            PrintDetails(c1);
            
        }

        static void PrintDetails(Circle c)
        {
            Console.WriteLine("area is {0}", c.CalculateArea());

            Console.WriteLine("Radius is {0} border color is {1} fill color is {2}", c.GetRadius(),
                c.GetBorderColor(), c.GetFillColor());

            Console.WriteLine("");

        }

        static void PrintDetails(Circle[] circles)
        {
            foreach (Circle c in circles)
            {
                PrintDetails(c);
            }

        }

        static void PrintTheBiggestCircle(Circle[] l)
        {
            float max = 0.0f;
            for (int i = 0; i < l.Length; i++)
            {
              
                foreach (Circle cir  in l)
                {
                    if (cir.CalculateArea() > max)
                    {
                        max = cir.CalculateArea();
                    }

                }
            }
            Console.WriteLine("");
            Console.WriteLine("The biggest circle is " +max);
        }
    }
}
