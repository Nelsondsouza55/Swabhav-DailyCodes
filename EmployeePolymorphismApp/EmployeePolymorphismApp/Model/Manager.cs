using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismApp.Model
{
    class Manager:Employee
    {
        private double _bSalary;
        private double _HRA;
        private double _TA;
        private double _DA;
        public Manager(int empno, string name, double bSalary, string type) :base(empno, name, bSalary, type)
        {

        }
        public void CalculateHRA()
        {
            _HRA = (50 / 100) * _bSalary;
            
           
        }

        public void CalculateTA()
        {
            _TA = (40 / 100) * _bSalary;
        }

        public void CalculateDA()
        {
            _DA = (30 / 100) * _bSalary;
        }

        public double GetHRA
        {
            get
            {
                return _HRA;
            }
        }

        public double GetTA
        {
            get
            {
                return _TA;
            }
        }

        public double GetDA
        {
            get
            {
                return _DA;
            }
        }

        public double GetAnnualSalary
        {
            get
            {
                return _bSalary + _HRA + _DA + _TA;
            }
        }
       
    }

}
