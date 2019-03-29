using System;
using System.Collections.Generic;
using System.Linq;

public class SerializeString
{
    public static void Main()
    {
        var symbols = Console.ReadLine();

        foreach (var symbol in symbols.Distinct())
        {
            Console.Write($"{symbol}:");
            var indexes = new List<int>();

            var index = symbols.IndexOf(symbol);

            while (index != -1)
            {
                indexes.Add(index);
                if (index + 1 > symbols.Length) break;
                index = symbols.IndexOf(symbol, index + 1);
            }

            Console.WriteLine(string.Join("/", indexes));
        }
    }
}

