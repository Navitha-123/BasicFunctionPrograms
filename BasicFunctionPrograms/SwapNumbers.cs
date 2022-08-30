using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograms
{
    internal class SwapNumbers
    {
        public static void SwapTwoNumbers()
        {
            int swap1 = 45, swap2 = 67, temp;
            temp = swap1;
            swap1 = swap2;
            swap2 = temp;
            Console.WriteLine("The numbers of swap1 and swap2 is ");
            Console.WriteLine(swap1);
            Console.WriteLine(swap2);
        }
    }
}
