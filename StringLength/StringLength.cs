using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int inputLength = input.Length;

            if (inputLength < 20)
            {
                int lengthToTwenty = 20 - inputLength;
                string additionSymbols = new string('*', lengthToTwenty);
                Console.WriteLine("{0}", input + additionSymbols);
            }
            else
            {
                string exactTwenty = input.Substring(0, 20);
                Console.WriteLine(exactTwenty);
            }
        }
    }
}