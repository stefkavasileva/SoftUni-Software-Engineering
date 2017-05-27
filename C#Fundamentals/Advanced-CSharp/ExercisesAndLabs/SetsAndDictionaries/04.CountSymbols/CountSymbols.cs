using System;
using System.Collections.Generic;

public class CountSymbols
{
    public static void Main()
    {
        var symbolCount = new SortedDictionary<char,int>();
        var text = Console.ReadLine();

        foreach (var symbol in text)
        {
            if (!symbolCount.ContainsKey(symbol))
            {
                symbolCount.Add(symbol,0);
            }

            symbolCount[symbol]++;
        }

        foreach (var currentSymbol in symbolCount)
        {
            Console.WriteLine($"{currentSymbol.Key}: {currentSymbol.Value} time/s");
        }
    }
}

