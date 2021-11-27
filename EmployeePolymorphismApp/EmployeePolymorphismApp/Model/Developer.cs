using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Developer:Employee
    {
        private double _bSalary;
        private double _PA;
        private double _OT;
        public Developer(int empno, string name, double bSalary, string type) : base(empno, name, bSalary, type)
        {

        }

        public void CalculatePA()
        {
            _PA = (40 / 100) * _bSalary;
        }

        public void CalculateOT()
        {
            _OT = (30 / 100) * _bSalary;
        }

        public double GetPA
        {
            get
            {
                return _PA;
            }
        }

        public double GetOT
        {
            get
            {
                return _OT;
            }
        }
    }
}
