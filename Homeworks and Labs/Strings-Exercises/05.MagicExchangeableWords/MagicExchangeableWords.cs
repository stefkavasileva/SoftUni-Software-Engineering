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

        if (firstStr.Length.Equals(secondStr.Length))
        {
            for (int i = 0; i < firstStr.Length; i++)
            {
                var firstLetter = firstStr[i];
                var secondLetter = secondStr[i];
                if (!letters.ContainsKey(firstLetter))
                {
                    letters.Add(firstLetter, secondLetter);
                }
                else if (letters[firstLetter] != secondLetter)
                {
                    isExchangeable = false;
                }
            }
        }
        else
        {
            isExchangeable = false;
        }

        return isExchangeable;
    }
}
