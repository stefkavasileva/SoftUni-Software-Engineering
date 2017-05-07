using System;
using System.Collections.Generic;
using System.Linq;

public class PopulationCounter
{
    public static void Main()
    {
        string inputLine = Console.ReadLine();

        var population = new Dictionary<string, Dictionary<string, long>>();

        while (!inputLine.Equals("report"))
        {
            string[] lineArgs = inputLine.Split('|').ToArray();

            string country = lineArgs[1];
            string city = lineArgs[0];
            int populationCount = int.Parse(lineArgs[2]);

            if (!population.ContainsKey(country))
            {
                population.Add(country, new Dictionary<string, long>());
            }

            if (!population[country].ContainsKey(city))
            {
                population[country].Add(city, 0);
            }

            population[country][city] += populationCount;

            inputLine = Console.ReadLine();
        }

        population = population
             .OrderByDescending(x => x.Value.Values.Sum())
             .ToDictionary(x => x.Key, x => x.Value);

        foreach (var country in population)
        {
            Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

            foreach (var city in country.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }
    }
}