using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPrograms
{
    internal class ConsonentsOrVowels
    {
        public static void VowelOrConsonentAlphabet()
        {
            Console.WriteLine("Enter an Alphabet");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'U' || ch == 'I' || ch == 'E' || ch == 'O')
            {
                Console.WriteLine(ch + "Character is vowel");
            }
            else
            {
                Console.WriteLine(ch + "Character is consonent");
            }
        }
    }
}
