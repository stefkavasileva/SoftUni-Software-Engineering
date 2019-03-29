using System;
using System.Linq;

public class CountOfCapitalLettersInArray
{
    public static void Main()
    {
        var text = Console.ReadLine().Split().ToArray();

        var capitalLettersCount = 0;

        for (int i = 0; i < text.Length; i++)
        {
            var currentWord = text[i];
            if (currentWord.Length == 1)
            {
                var letter = char.Parse(currentWord);
                if (char.IsUpper(letter))
                {
                    capitalLettersCount++;
                }
            }
        }

        Console.WriteLine(capitalLettersCount);
    }
}