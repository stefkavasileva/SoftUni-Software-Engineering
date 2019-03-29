using System;
using System.Collections.Generic;
using System.Linq;

public class OddOccurrences
{
    public static void Main()
    {
        var words = Console.ReadLine()
            .Split()
            .Select(w => w.ToLower())
            .ToArray();

        var wordsCount = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (!wordsCount.ContainsKey(word))
            {
                wordsCount.Add(word, 0);
            }

            wordsCount[word]++;
        }

        var wordsWithOddCount = wordsCount
            .Where(w => w.Value % 2 == 1)
            .ToDictionary(w => w.Key, w => w.Value)
            .Keys
            .ToList();

        Console.WriteLine(string.Join(", ", wordsWithOddCount));
    }
}
