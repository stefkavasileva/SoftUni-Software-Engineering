using System;
using System.Collections.Generic;

public class DigitsWithWords
{
    public static void Main()
    {
        var numberAsWords = new List<string> { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        Console.WriteLine(numberAsWords.IndexOf(Console.ReadLine()));
    }
}