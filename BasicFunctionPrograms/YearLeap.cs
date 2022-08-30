using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograms
{
    internal class YearLeap
    {
        public static void LeapYearOrNot()
        {
            int ch_year;
            Console.WriteLine("check year is leap year or not");
            Console.WriteLine("Enter an input");
            ch_year = Convert.ToInt32(Console.ReadLine());
            if (ch_year % 100 == 0)
            {
                Console.WriteLine("not a leap year ");
            }
            else
            {
                Console.WriteLine(" leap year ");
            }
        }
    }
}
