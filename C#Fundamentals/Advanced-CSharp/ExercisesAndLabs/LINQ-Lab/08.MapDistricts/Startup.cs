using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.MapDistricts
{
    public class Startup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var minPopulation = long.Parse(Console.ReadLine().Trim());
            var towns = new Dictionary<string, List<long>>();

            foreach (var item in inputLine)
            {
                var curretTownArgs = item.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                var name = curretTownArgs[0];
                var population = long.Parse(curretTownArgs[1]);

                if (!towns.ContainsKey(name))
                {
                    towns.Add(name, new List<long>());
                }

                towns[name].Add(population);
            }

            towns = towns.Where(t => t.Value.Sum() >= minPopulation)
                .OrderByDescending(x => x.Key)
                .OrderByDescending(x => x.Value.Sum())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var town in towns)
            {
                Console.WriteLine($"{town.Key}: {string.Join(" ", town.Value.OrderByDescending(x => x).Take(5))}");
            }

            //var input = Console.ReadLine();
            //var minPopulation = long.Parse(Console.ReadLine());

            //input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x =>
            //      {
            //          var curretTounArgs = x.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            //          var townName = curretTounArgs[0];
            //          var population = long.Parse(curretTounArgs[1]);

            //          return new { townName, population };
            //      }).GroupBy(
            //        x => x.townName,
            //        x => x.population,
            //        (town, population) => new
            //        {
            //            Result = town,
            //            Population = population.ToList()
            //        })
            //    .Where(x => x.Population.Sum() >= minPopulation)
            //    .OrderByDescending(x => x.Population.Sum())
            //    .ToList()
            //    .ForEach(x => Console.WriteLine($"{x.Result}: {string.Join(" ", x.Population.OrderByDescending(p => p).Take(5))}"));
        }
    }
}
