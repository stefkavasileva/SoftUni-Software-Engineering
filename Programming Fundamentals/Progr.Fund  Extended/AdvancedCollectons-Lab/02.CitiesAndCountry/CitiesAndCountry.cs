using System;
using System.Collections.Generic;

public class CitiesAndCountry
{
    public static void Main()
    {
        var lineCount = int.Parse(Console.ReadLine());
        var continents = new Dictionary<string,Dictionary<string,List<string>>>();

        for (int i = 0; i < lineCount; i++)
        {
            var tokens = Console.ReadLine().Split();

            var continent = tokens[0];
            var country = tokens[1];
            var city = tokens[2];

            if (!continents.ContainsKey(continent))
            {
                continents.Add(continent,new Dictionary<string, List<string>>());
            }

            if (!continents[continent].ContainsKey(country))
            {
                continents[continent].Add(country,new List<string>());
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
