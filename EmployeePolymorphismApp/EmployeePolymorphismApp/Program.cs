using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePolymorphismApp.Model;

namespace EmployeePolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSalarySlip();
            Console.ReadLine();
        }

        public static void PrintSalarySlip(Employee emp)
        {
            if (emp is Manager)
            {
                Manager m = new Manager(101, "nelson", 25000, "Manager");

                Console.WriteLine("The Salary Slip of manager is as follows");
                Console.WriteLine("The basic salary of a manager is {0}" , emp.BasicSalary);
                Console.WriteLine("The HRA of a manager is {0}" , emp.GetHRA);
                Console.WriteLine("The DA of a manager is {0}" , emp.GetDA);
                Console.WriteLine("The TA of a manager is {0}", emp.GetTA);
                Console.WriteLine("The annual income of a manager is {0}", emp.GetAnnualSalary);   
            }
        }
    }
}
