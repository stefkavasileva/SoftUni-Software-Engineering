namespace _03.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt").ToLower().Split().Distinct();
            var text = File
                .ReadAllText("text.txt")
                .ToLower()
                .Split(new[] { ' ', '-', ',', '.', '\'', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var wordsCount = new Dictionary<string, int>();

            int count = 0;
            foreach (var currentWourd in words)
            {
                foreach (var word in text)
                {
                    if (currentWourd == word)
                    {
                        count++;
                    }
                }

                wordsCount.Add(currentWourd, 0);
                wordsCount[currentWourd] += count;
                count = 0;
            }

            wordsCount = wordsCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in wordsCount)
            {
                File.AppendAllText("output.txt", $"{kvp.Key} - {kvp.Value}{Environment.NewLine}");
            }
        }
    }
}