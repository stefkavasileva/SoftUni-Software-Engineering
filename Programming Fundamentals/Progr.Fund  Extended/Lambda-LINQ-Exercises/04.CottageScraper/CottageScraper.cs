using System;
using System.Collections.Generic;
using System.Linq;

public class CottageScraper
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var materials = new Dictionary<string, List<long>>();
        var count = 0;
        var totalLen = 0.0;

        while (!inputLine.Equals("chop chop"))
        {
            count++;
            var tokens = inputLine
                .Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var name = tokens[0];
            var length = int.Parse(tokens[1]);

            if (!materials.ContainsKey(name))
            {
                materials.Add(name, new List<long>());
            }

            materials[name].Add(length);
            totalLen += length;

            inputLine = Console.ReadLine();
        }

        var type = Console.ReadLine();
        var minimumLen = int.Parse(Console.ReadLine());

        var pricePerMeter = Math.Round(totalLen / count, 2);

        var usedLogsPrice = materials[type]
            .Where(x => x >= minimumLen)
            .Sum() * pricePerMeter;

        usedLogsPrice = Math.Round(usedLogsPrice, 2);

        double unusedLogsPrice = materials
            .Where(x => x.Key != type)
            .ToDictionary(x => x.Key, x => x.Value)
            .Values
            .Select(x => x.Sum())
            .Sum() + materials[type]
            .Where(x => x < minimumLen)
            .Sum();

        unusedLogsPrice *= pricePerMeter * 0.25;

        unusedLogsPrice = Math.Round(unusedLogsPrice, 2);
        var totalPrice = usedLogsPrice + unusedLogsPrice;

        Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
        Console.WriteLine($"Used logs price: ${usedLogsPrice:f2}");
        Console.WriteLine($"Unused logs price: ${unusedLogsPrice:f2}");
        Console.WriteLine($"CottageScraper subtotal: ${totalPrice:f2}");
    }
}

