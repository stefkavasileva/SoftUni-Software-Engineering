using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SplitByWordCasing
{
    static void Main(string[] args)
    {
        char[] separators = ",;:.!()\"\'\\/[] ".ToCharArray();
        string[] words = Console.ReadLine().
            Split(separators, StringSplitOptions.
            RemoveEmptyEntries).ToArray();

        List<string> LowerCaseWords = new List<string>();
        List<string> UpperCaseWords = new List<string>();
        List<string> MixedCaseWords = new List<string>();

        for (int w = 0; w < words.Length; w++)
        {
            int lowerLetterCount = words[w].Count(c => Char.IsLower(c));
            int upperLetterCount = words[w].Count(c => Char.IsUpper(c));

            if (lowerLetterCount==words[w].Length)
            {
                LowerCaseWords.Add(words[w]);
            }
            else if (upperLetterCount==words[w].Length)
            {
                UpperCaseWords.Add(words[w]);
            }
            else
            {
                MixedCaseWords.Add(words[w]);
            }

        }

        Console.WriteLine($"Lower-case: {string.Join(", ",LowerCaseWords)}");
        Console.WriteLine($"Mixed-case: {string.Join(", ",MixedCaseWords)}");
        Console.WriteLine($"Upper-case: {string.Join(", ", UpperCaseWords)}");




    }
}

