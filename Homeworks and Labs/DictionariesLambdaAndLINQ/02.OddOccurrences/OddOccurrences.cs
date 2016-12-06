using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddOccurrences
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().ToLower().Split().ToArray();

        Dictionary<string, int> wordsCount = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (wordsCount.ContainsKey(words[i]))
            {
                wordsCount[words[i]]++;
            }
            else
            {
                wordsCount.Add(words[i], 1);
            }
        }

        List<string> oddWords = new List<string>();
        GetOddWords(wordsCount, oddWords);
        Console.WriteLine(string.Join(", ", oddWords));
    }

    private static void GetOddWords(Dictionary<string, int> wordsCount, List<string> oddWords)
    {
        foreach (var w in wordsCount)
        {
            if (w.Value % 2 != 0)
            {
                oddWords.Add(w.Key);
            }
        }
    }
}

