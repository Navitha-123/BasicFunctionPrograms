using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograms
{
    internal class PrimeNumberFactor
    {
        public static void PrimeFactorNumber()
        {
            int isPrime;
            Console.WriteLine("Enter number for prime factor");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = 1;
                    for (int j = 2; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = 0;
                            break;
                        }
                    }
                    if (isPrime == 1)
                    {
                        Console.WriteLine(i + "is prime factor");
                    }
                }
               
            }
        }
    }
}
