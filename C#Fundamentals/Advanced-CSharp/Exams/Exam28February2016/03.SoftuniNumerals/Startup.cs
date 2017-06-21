using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.SoftuniNumerals
{
    public class Startup
    {
        public static void Main()
        {
            var numbersAsStr = new List<string> {"aa", "aba", "bcc", "cc", "cdc"};
            var text = Console.ReadLine();

            var numberAsStr = new StringBuilder();
            var matches = new Regex($"aa|aba|bcc|cc|cdc").Matches(text);
            foreach (Match match in matches)
            {
                numberAsStr.Append(numbersAsStr.IndexOf(match.Value));
            }

            var number = BigInteger.Parse(numberAsStr.ToString());
            var decimalNum = FromBase(number, 5);
            Console.WriteLine(decimalNum);
        }

        public static BigInteger FromBase(BigInteger value, int @base)
        {
            string number = value.ToString();
            BigInteger n = 1;
            BigInteger r = 0;

            for (int i = number.Length - 1; i >= 0; --i)
            {
                r += n * (number[i] - '0');
                n *= @base;
            }

            return r;
        }
    }
}
