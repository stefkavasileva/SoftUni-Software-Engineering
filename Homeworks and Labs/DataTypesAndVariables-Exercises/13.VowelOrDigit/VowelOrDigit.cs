using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class VowelOrDigit
{
    static void Main(string[] args)
    {
        char symbol = char.Parse(Console.ReadLine().ToLower());

        char[] vowelLetter = new char[] { 'a', 'e', 'u', 'i', 'o' };

        if (char.IsDigit(symbol))
        {
            Console.WriteLine("digit");
        }
        else if (char.IsLetter(symbol) && vowelLetter.Contains(symbol))
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}

