using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Employee
    {
        private int _empno;
        private string _name;
        private double _bSalary;
        private string _type;
        public Employee(int empno, string name, double bSalary, string type)
        {
            _empno = empno;
            _name = name;
            _bSalary = bSalary;
            _type = type;
        }


        public int GetEmpno
        {
            get
            {
                return _empno;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double BasicSalary
        {
            get
            {
                return _bSalary;
            }
        }

        public string type
        {
            get
            {
                return _type;
            }
        }


    }
}
