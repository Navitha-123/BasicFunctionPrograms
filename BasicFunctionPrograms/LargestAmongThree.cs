using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograms
{
    internal class LargestAmongThree
    {
        public static void AmongThreeLargestNumbers()
        {
            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num3");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The num1 is largest");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The num2 is largest");
            }
            else
            {
                Console.WriteLine("The num3 is largest");
            }
        }
    }
}
