using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PopulationCounter
{
    static void Main(string[] args)
    {
        var countryPopulation = new Dictionary<string, Dictionary<string, long>>();
        string inputLine = Console.ReadLine();

        while (!inputLine.Equals("report"))
        {
            string[] comandArgs = inputLine.Split('|').ToArray();
            string country = comandArgs[1];
            string town = comandArgs[0];
            long populationInTown = long.Parse(comandArgs[2]);

            if (!countryPopulation.ContainsKey(country))
            {
                countryPopulation.Add(country, new Dictionary<string, long>());
            }

            if (!countryPopulation[country].ContainsKey(town))
            {
                countryPopulation[country].Add(town, populationInTown);
            }
            else
            {
                countryPopulation[country][town] += populationInTown;
            }

            inputLine = Console.ReadLine();
        }


        countryPopulation = countryPopulation
                .OrderByDescending(c => c.Value.Values.Sum(t => t))
                .ToDictionary(x => x.Key, x => x.Value);

        foreach (var country in countryPopulation)
        {
            var towns = country.Value.OrderByDescending(c => c.Value).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("{0} (total population: {1})", country.Key, towns.Values.Sum(x => x));

            foreach (var town in towns)
            {
                Console.WriteLine("=>{0}: {1}", town.Key, town.Value);
            }

        }
    }
}

