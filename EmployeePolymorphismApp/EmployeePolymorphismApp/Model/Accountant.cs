using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Accountant:Employee
    {
        private double _bSalary;
        private double _perks;
        public Accountant(int empno, string name, double bSalary, string type) : base(empno, name, bSalary, type)
        {

        }

        public void CalculatePerks()
        {
            _perks = (30 / 100) * _bSalary;
        }

        public double GetPerks
        {
            get
            {
                return _perks;
            }
        }
    }
}
