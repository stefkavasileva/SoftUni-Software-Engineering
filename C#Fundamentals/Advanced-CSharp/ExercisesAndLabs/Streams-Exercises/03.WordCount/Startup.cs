using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    public class Startup
    {
        public static void Main()
        {
            var filePath = Console.ReadLine();
            var fileLines = ReadFile(filePath);

            var wordsFIlePath = Console.ReadLine();
            var wordsToBeCount = ReadFile(wordsFIlePath);

            var wordsCount = new Dictionary<string, int>();

            foreach (var fileLine in fileLines)
            {
                var wordsInLine = fileLine
                    .ToLower()
                    .Split(new[] { ' ',',','.','-' }, StringSplitOptions.RemoveEmptyEntries);

                for (int wordIndex = 0; wordIndex < wordsInLine.Length; wordIndex++)
                {
                    if (wordsToBeCount.Contains(wordsInLine[wordIndex]))
                    {
                        if (!wordsCount.ContainsKey(wordsInLine[wordIndex]))
                        {
                            wordsCount.Add(wordsInLine[wordIndex], 0);
                        }

                        wordsCount[wordsInLine[wordIndex]]++;
                    }
                }
            }

            using (var writer = new StreamWriter("../../result.txt"))
            {
                foreach (var kvp in wordsCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }

        private static List<string> ReadFile(string wordsFIlePath)
        {
            var lines = new List<string>();
            using (var reader = new StreamReader(wordsFIlePath))
            {
                var currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    lines.Add(currentLine.ToLower());
                    currentLine = reader.ReadLine();
                }
            }

            return lines;
        }
    }
}
