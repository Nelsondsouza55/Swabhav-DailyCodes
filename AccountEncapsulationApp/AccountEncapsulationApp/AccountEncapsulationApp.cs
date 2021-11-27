using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountEncapsulationApp.Model;

namespace AccountEncapsulationApp
{
    class AccountEncapsulationApp
    {
        static void Main(string[] args)
        {

            Part2();

           


            Console.ReadLine();
        }

        public static void Part1()
        {
            Account a0 = new Account("Nelson", 1335, 1000);
            PrintDetails(a0);
            a0.Deposit(1200);
            PrintDetails(a0);
            a0.Withdraw(501);
            PrintDetails(a0);
        }


        public static void Part2()
        {
            Account[] manyAccounts = new Account[3];
            Account a1 = new Account("Nelson", 1220, 10000);
            Account a2 = new Account("Vinay", 1221, 5000);
            Account a3 = new Account("Raj", 1222, 1000);

            manyAccounts[0] = a1;
            manyAccounts[1] = a2;
            manyAccounts[2] = a3;


            PrintDetails(manyAccounts);

            Account rich = Richuser(manyAccounts);


            PrintDetails(rich);

            DistWealth(manyAccounts);

        }

        public static void PrintDetails(Account a)
        {
            Console.WriteLine("The account name " +a.Getname());
            Console.WriteLine("The account number " +a.GetAccountNumber());
            Console.WriteLine("The balance is " +a.GetBalance());
            Console.WriteLine("");
        }

        public static void PrintDetails(Account[] ar)
        {
            foreach (Account a in  ar)
            {
                PrintDetails(a);
            }
        }

        public static Account Richuser(Account[] r)
        {
            double max = 0 ;
            
            Account richestUser = r[0];
         
                foreach (Account ac in r)
                {
                    if (ac.GetBalance() > max)
                    {
                        max = ac.GetBalance();
                      richestUser = ac;


                    }


                }

            return richestUser;
      
        }

        public static void DistWealth(Account[] w)
        {
            Account userRich =  Richuser(w);
           // Account s= w[0];

            double rWealth = userRich.GetBalance() - 500;

            int len = w.Length - 1;
            double eWealth = rWealth / len;

            for (int i = 0; i < w.Length; i++)
            {
                while (w[i] != userRich )
                {
                    w[i].Deposit(eWealth);
                }

            }

            PrintDetails(w);
        }

    }
}
