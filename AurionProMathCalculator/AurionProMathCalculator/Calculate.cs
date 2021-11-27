using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AurionProMathCalculator
{
    public class Calculator
    {
        public bool PrimeNoCheck(double x)
        {
            bool response = true;
            double mono = 0;
            int flag = 0;

            mono = x / 2;
            for (int i = 2; i < mono; i++)
            {
                if (x % i == 0)
                {
                    response = true;
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                response = false;
            }


            return response;
        }

        public void GeneratePrime(int x)
        {
            int[] primeNumbers = new int[x];
            for (int j = 0; j <= x; j++)
            {
                int ctr = 0;
                int count = 0;
                for (int i = 2; i < x / 2; i++)
                {
                    if (x % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                
                if (ctr == 0 && x!=1)
                {
                   
                    primeNumbers[count] = j;
                    count= count + 1;
                }             
            }
            for (int i = 0; i < primeNumbers.Length; i++)
            {
                Console.WriteLine("The prime number generated till the limit {0}", x);
                Console.WriteLine("{0}", primeNumbers[i]);
            }
        }

        public void GenerateEvenNo(int x)
        {
            int[] evenNumbers = new int[(x/2)-1];
            int counter = 0;
            for (int i = 2; i < x; i+=2)
            {
                evenNumbers[counter] = i;
                counter += 1;
            }
            for (int i = 0; i < evenNumbers.Length; i++)
            {
                Console.WriteLine("The even number generated till the limit {0}", x);
                Console.WriteLine("{0}",evenNumbers[i]);
            }
        }
    }
    
}
