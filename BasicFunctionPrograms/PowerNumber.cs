using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograms
{
    internal class PowerNumber
    {
        public static void PowerofTwo()
        {
            Console.WriteLine("Enter range for finding power table");
            int range = Convert.ToInt32(Console.ReadLine());
            if (range < 0 || range > 31)
            {
                Console.WriteLine("Enter the number in between the range");
            }
            else
            {
                for (int i = 0; i < range; i++)
                {
                    Console.WriteLine((int)Math.Pow(i, 2));
                }
            }
        }
    }
}
