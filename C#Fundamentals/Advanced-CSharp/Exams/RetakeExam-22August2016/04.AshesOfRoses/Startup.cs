using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.AshesOfRoses
{
    public class Startup
    {
        public static void Main()
        {
            var reg = new Regex(@"^Grow\s<([A-Z][a-z]+)>\s<([A-Za-z\d]+)>\s(\d+)$");
            var regions = new Dictionary<string, Dictionary<string, long>>();

            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("Icarus, Ignite!"))
            {
                var match = reg.Match(inputLine);
                if (match.Success)
                {
                    var regionName = match.Groups[1].Value;
                    var colorName = match.Groups[2].Value;
                    var rosesCount = int.Parse(match.Groups[3].Value);

                    if (!regions.ContainsKey(regionName))
                    {
                        regions.Add(regionName, new Dictionary<string, long>());
                    }

                    if (!regions[regionName].ContainsKey(colorName))
                    {
                        regions[regionName].Add(colorName, 0);
                    }

                    regions[regionName][colorName] += rosesCount;
                }

                inputLine = Console.ReadLine();
            }

            regions = regions
                .OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var region in regions)
            {
                Console.WriteLine(region.Key);

                var roses = region
                    .Value
                    .OrderBy(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var rose in roses)
                {
                    Console.WriteLine($"*--{rose.Key} | {rose.Value}");
                }
            }
        }
    }
}
