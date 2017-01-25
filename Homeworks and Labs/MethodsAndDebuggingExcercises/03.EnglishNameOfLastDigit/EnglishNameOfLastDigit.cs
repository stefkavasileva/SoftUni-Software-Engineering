using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EnglishNameOfLastDigit
{
    static void Main(string[] args)
    {
        string inputNumberAsStr = Console.ReadLine();

        int lastDigit =int.Parse(inputNumberAsStr.Substring(inputNumberAsStr.Length - 1));

        string digitName = GetDigitName(lastDigit);

        Console.WriteLine(digitName);
    }

    private static string GetDigitName(int lastDigit)
    {
        string [] numberText= new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        return numberText[lastDigit];
    }
}

