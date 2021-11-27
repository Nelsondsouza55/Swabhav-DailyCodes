using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEncapsulationApp.Model
{
    class Account
    {
        private String _name;
        private int _accountNumber;
        private double _balance;

        public Account(String name , int accountNumber , double balance)
        {
            _name = name;
            _accountNumber = accountNumber;
            _balance = balance;
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {
            _balance = _balance - amount;

            if (_balance < 500)
            {
                Console.WriteLine("The minimum amount of 500 must be there in the bank");
                Console.WriteLine("");
                _balance = _balance + amount;
            }
        }

        public override String ToString()
        {
            String output = "The name is " + this._name + "Having balance " + Convert.ToString(this._balance) + "Account no: " + Convert.ToString(this._accountNumber); 
            return output +" \n Parent ->"+base.ToString();
        }

        public override bool Equals(Account acc1, Account acc2)
        {
            acc1.Equals(acc2) = true;
            return acc1.Equals(acc2) ;
        }



        public String Getname()
        {
            return _name;
        }

        public double GetAccountNumber()
        {
            return _accountNumber;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
