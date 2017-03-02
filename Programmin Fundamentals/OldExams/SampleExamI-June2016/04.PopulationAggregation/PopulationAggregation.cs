using System;
using System.Collections.Generic;
using System.Linq;

public class PopulationAggregation
{
    public static void Main()
    {
        string inputLine = Console.ReadLine();
        SortedDictionary<string, int> countryCount = new SortedDictionary<string, int>();
        Dictionary<string, long> townPopulation = new Dictionary<string, long>();

        while (!inputLine.Equals("stop"))
        {
            string[] populationArgs = inputLine.Split('\\').ToArray();
            long populationsCount = long.Parse(populationArgs[2]);
            populationArgs[0] = RemoveProhibitedSymbols(populationArgs[0]);
            populationArgs[1] = RemoveProhibitedSymbols(populationArgs[1]);
            string countryName = string.Empty;
            string townName = string.Empty;
            if (char.IsUpper(populationArgs[0], 0))
            {
                countryName = populationArgs[0];
                townName = populationArgs[1];
            }
            else
            {
                countryName = populationArgs[1];
                townName = populationArgs[0];
            }

            if (!countryCount.ContainsKey(countryName))
            {
                countryCount.Add(countryName, 0);
            }

            countryCount[countryName]++;

            if (!townPopulation.ContainsKey(townName))
            {
                townPopulation.Add(townName, 0);
            }

            townPopulation[townName] = populationsCount;

            inputLine = Console.ReadLine();
        }

        PrintCountry(countryCount);

        var topTowns = townPopulation
            .OrderByDescending(t => t.Value)
            .Take(3)
            .ToDictionary(t => t.Key, t => t.Value);

        PrintTopTowns(topTowns);
    }

    private static void PrintTopTowns(Dictionary<string, long> topTowns)
    {
        foreach (var town in topTowns)
        {
            Console.WriteLine($"{town.Key} -> {town.Value}");
        }
    }

    private static void PrintCountry(SortedDictionary<string, int> countryCount)
    {
        foreach (var country in countryCount)
        {
            Console.WriteLine($"{country.Key} -> {country.Value}");
        }
    }

    private static string RemoveProhibitedSymbols(string populationArgs)
    {
        char[] symbols = "@#$&0123456789".ToCharArray();
        for (int index = 0; index < symbols.Length; index++)
        {
            if (populationArgs.Contains(symbols[index]))
            {
                populationArgs = populationArgs.Replace(symbols[index].ToString(), string.Empty);
            }
        }

        return populationArgs;
    }
}