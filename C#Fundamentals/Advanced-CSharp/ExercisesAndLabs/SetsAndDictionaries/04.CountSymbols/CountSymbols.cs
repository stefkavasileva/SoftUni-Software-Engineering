using System;
using System.Collections.Generic;

public class CountSymbols
{
    public static void Main()
    {
        var text = Console.ReadLine();

        var symbolsCount = new SortedDictionary<char, int>();

        foreach (var symbol in text)
        {
            if (!symbolsCount.ContainsKey(symbol))
            {
                symbolsCount.Add(symbol, 0);
            }

            symbolsCount[symbol]++;
        }

        foreach (var symbol in symbolsCount)
        {
            Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
        }
    }
}

