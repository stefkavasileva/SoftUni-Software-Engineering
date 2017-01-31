using System;

public class EnglishNameOfLastDigit
{
    public static void Main()
    {
        string inputNumberAsStr = Console.ReadLine();

        int lastDigit = int.Parse(inputNumberAsStr.Substring(inputNumberAsStr.Length - 1));

        string digitName = GetDigitName(lastDigit);

        Console.WriteLine(digitName);
    }

    private static string GetDigitName(int lastDigit)
    {
        string[] numberText = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        return numberText[lastDigit];
    }
}
