using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograms
{
    internal class HeadAndTail
    {
        public static void CalculatePercentage()
        {
            int headcount = 0, tailcount = 0;
            double headpercentage;
            double tailpercentage;
            Console.WriteLine("please enter a value number of flips ypu want");
            int flipcoin = Convert.ToInt32(Console.ReadLine());

            if (flipcoin > 0)
            {
                for (int i = 0; i < flipcoin; i++)
                {
                    Random random = new Random();
                    double number = random.NextDouble();  //0,1
                    if (number > 0.5)
                    {
                        Console.WriteLine("head");
                        headcount++;

                    }
                    else
                    {
                        Console.WriteLine("tail");
                        tailcount++;
                    }
                }
                headpercentage = headcount * 100 / flipcoin;
                tailpercentage = tailcount * 100 / flipcoin;
                Console.WriteLine("headpercentage " + headpercentage + "tailpercentage" + tailpercentage);
            }
            else
            {
                Console.WriteLine("Enter wrong choice");
            }

        }

    }
}
