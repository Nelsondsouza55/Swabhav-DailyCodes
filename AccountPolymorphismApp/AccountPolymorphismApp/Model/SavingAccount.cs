﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    class SavingAccount:Account
    {
        public SavingAccount(int accno, String name, double balance) : base(accno, name, balance)
        {

        }

        public override void Withdraw(double amount)
        {
            

        }

    }
}
