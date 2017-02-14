using System;
using System.Collections.Generic;

public class MagicExchangeableWords
{
    public static void Main()
    {
        var inputLine = Console.ReadLine().Split();
        var firstString = inputLine[0];
        var secondString = inputLine[1];

        bool isExchangeble = IsExchangeble(firstString, secondString);

        Console.WriteLine(isExchangeble.ToString().ToLower());

    }

    private static bool IsExchangeble(string firstString, string secondString)
    {
        var letters = new Dictionary<char, char>();

        for (int i = 0; i < firstString.Length; i++)
        {
            var firstWordLetter = firstString[i];
            var secondWordLetter = secondString[i];

            if (!letters.ContainsKey(firstWordLetter))
            {
                letters.Add(firstWordLetter, secondWordLetter);
            }
            else if (!letters[firstWordLetter].Equals(secondWordLetter))
            {
                return false;
            }
        }
              
        return true;
    }
}

