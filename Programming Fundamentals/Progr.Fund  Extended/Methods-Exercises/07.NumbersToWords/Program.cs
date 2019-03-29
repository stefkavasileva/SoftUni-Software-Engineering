using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        var numbersCount = int.Parse(Console.ReadLine());
        var result = new StringBuilder();

        for (int i = 0; i < numbersCount; i++)
        {
            var currentNum = int.Parse(Console.ReadLine());

            if (currentNum.ToString().Length < 3) continue;
            else if (currentNum > 999) result.AppendLine("too large");
            else if (currentNum < -999) result.AppendLine("too small");
            else result.AppendLine(NumberToWords(currentNum));
        }

        Console.Write(result);
    }

    public static string NumberToWords(int number)
    {
        if (number == 0)
            return "zero";

        if (number < 0)
            return "minus " + NumberToWords(Math.Abs(number));

        string words = "";

        if ((number / 1000000) > 0)
        {
            words += NumberToWords(number / 1000000) + " million ";
            number %= 1000000;
        }

        if ((number / 1000) > 0)
        {
            words += NumberToWords(number / 1000) + " thousand ";
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += NumberToWords(number / 100) + "-hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += " " + unitsMap[number % 10];
            }
        }

        return words;
    }
}
