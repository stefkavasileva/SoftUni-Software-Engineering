using System;
using System.Collections.Generic;
using System.Linq;

public class OddOccurrences
{
    public static void Main()
    {
        string[] words = Console.ReadLine().ToLower().Split();

        var wordsCount = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (!wordsCount.ContainsKey(word))
            {
                wordsCount.Add(word, 0);
            }

            wordsCount[word]++;
        }

        var oddWords = wordsCount
            .Where(w => w.Value % 2 == 1)
            .ToDictionary(x => x.Key, x => x.Value)
            .Keys
            .ToArray();

        Console.WriteLine(string.Join(", ", oddWords));
    }
}
