namespace BasicFunctionPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("welcome to function programming");
            Console.WriteLine("choose option\n 1.flipcoin \t 2.Leap year \t 3. power of two \t 4. Harmonic number \t 5.Primenumber \t 6.Quotient And Remainder \t 7. swap \t 8. Even  Or Odd \t 9. Vowel Consonent \t 10. largest three numbers");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    HeadAndTail.CalculatePercentage();
                    break;
                case 2:
                    YearLeap.LeapYearOrNot();
                    break;
                case 3:
                    PowerNumber.PowerofTwo();
                    break;
                case 4:
                    HarmonicValue.HormonicNumber();
                    break;
                case 5:
                    PrimeNumber.PrimeFactorNumber();
                    break;
                case 6:
                    RemainderAndQuotient.QuatientAndRemainderNumber();
                    break;
                case 7:
                    SwapNumbers.SwapTwoNumbers();
                    break;

            }
        }
    }
}