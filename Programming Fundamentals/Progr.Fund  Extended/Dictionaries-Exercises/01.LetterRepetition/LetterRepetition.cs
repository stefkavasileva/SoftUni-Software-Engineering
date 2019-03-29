using System;
using System.Collections.Generic;

public class LetterRepetition
{
    public static void Main()
    {
        var text = Console.ReadLine();

        var symbolCount = new Dictionary<char, int>();

        foreach (var symbol in text)
        {
            if (!symbolCount.ContainsKey(symbol))
            {
                symbolCount.Add(symbol,0);
            }

            symbolCount[symbol]++;
        }

        foreach (var kvp in symbolCount)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}
