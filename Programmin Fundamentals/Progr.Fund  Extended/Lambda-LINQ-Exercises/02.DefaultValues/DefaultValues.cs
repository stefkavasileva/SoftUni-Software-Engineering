using System;
using System.Collections.Generic;
using System.Linq;

public class DefaultValues
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var pairs = new Dictionary<string,string>();

        while (!inputLine.Equals("end"))
        {
            var tokens = inputLine.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var key = tokens[0];
            var value = tokens[1];

            if (!pairs.ContainsKey(key))
            {
                pairs.Add(key,string.Empty);
            }

            pairs[key] = value;

            inputLine = Console.ReadLine();
        }

        var defaultValue = Console.ReadLine();

        var notNullResult = pairs.Where(x => !x.Value.Equals("null")).OrderByDescending(x=>x.Value.Length);
        var nullResult = pairs.Where(x => x.Value.Equals("null"));
        
        foreach (var kvp in notNullResult)
        {
            Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
        }

        foreach (var kvp in nullResult)
        {
            Console.WriteLine($"{kvp.Key} <-> {defaultValue}");
        }
    }
}

