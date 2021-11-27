using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    abstract class Account
    {
        private int _accno;
        private String _name;
        private double _balance;

        public Account(int accno, String name, double balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
        }

        public void Deposit(double amt)
        {
            _balance = _balance + amt;
        }

        public abstract void Withdraw(double amount);

        public int AccountNumber
        {
            get
            {
                return _accno;
            }


        }

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }
    }
}
