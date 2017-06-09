using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _04.CubicAssault
{
    public class Region
    {
        public string Name { get; set; }

        public BigInteger BlackMeteors { get; set; }

        public BigInteger RedMeteors { get; set; }

        public BigInteger GreenMeteors { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            var regions = new List<Region>();

            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("Count em all"))
            {
                var tokens = inputLine
                    .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => t.Trim())
                    .ToArray();

                var regionName = tokens[0];
                var meteorsType = tokens[1];
                var count = BigInteger.Parse(tokens[2]);

                if (!regions.Any(r => r.Name == regionName))
                {
                    var newRegion = new Region { Name = regionName, BlackMeteors = 0, GreenMeteors = 0, RedMeteors = 0 };
                    regions.Add(newRegion);
                }

                var currntregion = regions.First(r => r.Name == regionName);
                if (meteorsType.ToLower().Equals("green"))
                {
                    currntregion.GreenMeteors += count;
                    if (currntregion.GreenMeteors >= 1000000)
                    {
                        var value = currntregion.GreenMeteors / 1000000;
                        currntregion.GreenMeteors %= 1000000;
                        currntregion.RedMeteors += value;
                        if (currntregion.RedMeteors >= 1000000)
                        {
                            value = currntregion.RedMeteors / 1000000;
                            currntregion.RedMeteors %= 1000000;
                            currntregion.BlackMeteors += value;
                        }
                    }
                }
                else if (meteorsType.ToLower().Equals("red"))
                {
                    currntregion.RedMeteors += count;
                    if (currntregion.RedMeteors >= 1000000)
                    {
                        var value = currntregion.RedMeteors / 1000000;
                        currntregion.RedMeteors %= 1000000;
                        currntregion.BlackMeteors += value;
                    }

                }
                else
                {
                    currntregion.BlackMeteors += count;
                }

                inputLine = Console.ReadLine();
            }

            regions = regions
                .OrderByDescending(r => r.BlackMeteors)
                .ThenBy(r => r.Name.Length)
                .ThenBy(r => r.Name)
                .ToList();

            foreach (var region in regions)
            {
                Console.WriteLine(region.Name);
                var meteors = new Dictionary<string, BigInteger>();
                meteors.Add("Red", region.RedMeteors);
                meteors.Add("Green", region.GreenMeteors);
                meteors.Add("Black", region.BlackMeteors);

                meteors = meteors
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var meteor in meteors)
                {
                    Console.WriteLine($"-> {meteor.Key} : {meteor.Value}");
                }
            }
        }
    }
}
