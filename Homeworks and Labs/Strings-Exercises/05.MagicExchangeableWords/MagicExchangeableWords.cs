using System;
using System.Collections.Generic;
using System.Linq;

public class MagicExchangeableWords
{
    public static void Main()
    {
        var inputLine = Console.ReadLine().Split().ToArray();
        var firstStr = inputLine[0];
        var secondStr = inputLine[1];

        var letters = new Dictionary<char, char>();

        bool isExchangeable = IsExchangeable(firstStr, secondStr, letters);

        Console.WriteLine(isExchangeable.ToString().ToLower());
    }

    public static bool IsExchangeable(string firstStr, string secondStr, Dictionary<char, char> letters)
    {
        bool isExchangeable = true;
        var minLen = Math.Min(firstStr.Length, secondStr.Length);

        for (int i = 0; i < minLen; i++)
        {
            var firstLetter = firstStr[i];
            var secondLetter = secondStr[i];

            if (!letters.ContainsKey(firstLetter))
            {
                if (letters.ContainsValue(secondLetter))
                {
                    return false;
                }

                letters.Add(firstLetter, secondLetter);
            }
            else if (letters[firstLetter] != secondLetter)
            {
                isExchangeable = false;
            }
        }

        if (firstStr.Length != secondStr.Length)
        {
            var longerStr = firstStr.Length > secondStr.Length ? firstStr : secondStr;
            var remainingLetters = longerStr.Substring(Math.Min(firstStr.Length, secondStr.Length));

            foreach (char letter in remainingLetters)
            {
                if (!letters.ContainsKey(letter) && !letters.ContainsValue(letter))
                {
                    return false;
                }
            }
        }

        return isExchangeable;
    }
}