using System;
using System.Collections.Generic;

public class GroupContinents
{
    public static void Main()
    {
        var count = int.Parse(Console.ReadLine());

        var continents = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
        for (int i = 0; i < count; i++)
        {
            var tokens = Console.ReadLine().Split();

            var continent = tokens[0];
            var country = tokens[1];
            var city = tokens[2];

            if (!continents.ContainsKey(continent))
            {
                continents.Add(continent,new SortedDictionary<string, SortedSet<string>>());
            }

            if (!continents[continent].ContainsKey(country))
            {
                continents[continent].Add(country,new SortedSet<string>());
            }

            continents[continent][country].Add(city);
        }

        foreach (var continent in continents)
        {
            Console.WriteLine($"{continent.Key}:");
            foreach (var country in continent.Value)
            {
                Console.WriteLine($"  {country.Key} -> {string.Join(", ",country.Value)}");
            }
        }
    }
}