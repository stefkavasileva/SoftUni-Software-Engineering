using System;
using System.Collections.Generic;
using System.Linq;

public class CapitalizeWords
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        while (!inputLine.Equals("end"))
        {
            var words = inputLine
                .Split(".?!, -:;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var allWords = new List<string>();

            foreach (var word in words)
            {
                var currentWord = word.Substring(0, 1).ToUpper() + (new string(word.Skip(1).ToArray())).ToLower();
                allWords.Add(currentWord);
            }

            Console.WriteLine(string.Join(", ", allWords));
            inputLine = Console.ReadLine();
        }
    }
}

