using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograms
{
    internal class RemainderAndQuotient
    {

        public static void QuatientAndRemainderNumber()
        {
            int divd = 78, divs = 20;
            int quo, rem;
            quo = divd / divs;
            rem = divd % divs;
            Console.WriteLine(+divd + "is divdend by" + divs + "quotient is " + quo + "remainder is" + rem + ".");
            Console.ReadLine();
        }
    }
}
