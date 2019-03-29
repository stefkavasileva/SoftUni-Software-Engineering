using System;
using System.Collections.Generic;
using System.Linq;

public class SplitByWordCasing
{
    public static void Main()
    {
        char[] delimiters = ",;:.!()\"\'\\/[] ".ToCharArray();

        List<string> words = Console.ReadLine()
            .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<string> upperCaseWords = new List<string>();
        List<string> lowerCaseWords = new List<string>();
        List<string> mixedCaseWords = new List<string>();

        foreach (var word in words)
        {
            if (word.Any(x => !char.IsLetter(x)))
            {
                mixedCaseWords.Add(word);
            }
            else if (word.ToUpper().Equals(word))
            {
                upperCaseWords.Add(word);
            }
            else if (word.ToLower().Equals(word))
            {
                lowerCaseWords.Add(word);
            }
            else
            {
                mixedCaseWords.Add(word);
            }
        }

        Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
        Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
        Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
    }
}