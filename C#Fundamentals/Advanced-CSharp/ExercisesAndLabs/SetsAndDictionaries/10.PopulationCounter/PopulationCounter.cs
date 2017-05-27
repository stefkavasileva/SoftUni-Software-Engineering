using System;
using System.Collections.Generic;
using System.Linq;

public class PopulationCounter
{
    public static void Main()
    {
        var countries = new List<Country>();
        var input = Console.ReadLine();
        while (!input.Equals("report"))
        {
            var tokens = input.Split('|');
            var cityName = tokens[0];
            var country = tokens[1];
            var populationCount = int.Parse(tokens[2]);

            if (!countries.Any(c => c.Name == country))
            {
                var newCountry = new Country(country);
                countries.Add(newCountry);
            }

            var city = new City(cityName, populationCount);
            countries.FirstOrDefault(c => c.Name == country).TotalPopulation += populationCount;
            countries.FirstOrDefault(c => c.Name == country).Cities.Add(city);

            input = Console.ReadLine();
        }

        countries = countries.OrderByDescending(x => x.TotalPopulation).ToList();

        foreach (var country in countries)
        {
            Console.Write(country);
        }
    }
}