using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograms
{
    internal class HarmonicValue
    {
        public static void HormonicNumber()
        {
            double num = 0;
            Console.WriteLine("Enter the hormonic value you want to find");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("1 / {0} + ", i);
                num += (1 / (float)i);
                Console.WriteLine();

                Console.WriteLine("Hormonic value {0} is : {1}", n, num);

            }
        }
    }
}
