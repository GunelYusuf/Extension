using System;
using System.Text.RegularExpressions;

namespace ExtensionTask
{
    static class Extension
    {
        public static int MatchCount(this string msg, string pattern)
        {
            int Count = 0;
            MatchCollection FindWord = Regex.Matches(msg, @"\b(\w*Gunel\w*)\b");
            foreach (var i in FindWord)
            {
                Count++;
            }
            return Count;
        }


        public static void Polendrom(this int x)
        {
            int Reverse = 0;

            for (int i = x; i > 0; i/= 10)
            {
               Reverse =(Reverse * 10) + i % 10;
            }
            if (x == Reverse)
            {
                Console.WriteLine($"{x} Polendrom'dur");

            }
            else
            {
                Console.WriteLine($"{x} Polendrom deyil");
            }

        }


    }
}