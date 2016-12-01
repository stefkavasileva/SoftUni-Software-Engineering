using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EnglishNameOfLastDigit
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();

        string lastDigtAsText = GetLastDigitText(number);

        Console.WriteLine(lastDigtAsText);
    }

    private static string GetLastDigitText(string number)
    {
        string lastDigitAsStr = number.Substring(number.Length - 1);
        int lastDigit = int.Parse(lastDigitAsStr);
        string[] numsAsText = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string lastDigitText = numsAsText[lastDigit];
        return lastDigitText;
    }
}

