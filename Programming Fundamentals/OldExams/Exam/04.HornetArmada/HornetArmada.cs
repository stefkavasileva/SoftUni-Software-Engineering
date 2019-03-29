using System;
using System.Collections.Generic;
using System.Linq;

public class HornetArmada
{
    public static void Main()
    {
        var separators = "->: =".ToCharArray();
        var soldierActivities = new Dictionary<string, long>();
        var soldierTypes = new Dictionary<string, Dictionary<string, long>>();

        var count = long.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            var soldierArgs = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var activity = long.Parse(soldierArgs[0].Trim());
            var name = soldierArgs[1];
            var type = soldierArgs[2];
            var soldierCount = 0L;

            if (soldierArgs.Count() > 3)
            {
                soldierCount = long.Parse(soldierArgs[3]);
            }

            if (!soldierActivities.ContainsKey(name))
            {
                soldierActivities.Add(name, long.MinValue);
            }

            if (soldierActivities[name] < activity)
            {
                soldierActivities[name] = activity;
            }

            if (!soldierTypes.ContainsKey(name))
            {
                soldierTypes.Add(name, new Dictionary<string, long>());
            }

            if (!soldierTypes[name].ContainsKey(type))
            {
                soldierTypes[name].Add(type, 0);
            }

            soldierTypes[name][type] += soldierCount;
        }


        var inputLine = Console.ReadLine().Split('\\');

        if (inputLine.Length > 1)
        {
            var currentActivity = int.Parse(inputLine[0].Trim());
            var soldierType = inputLine[1].Trim();

            var keys = soldierActivities.Where(x => x.Value < currentActivity).Select(x => x.Key).ToList();
            var result = new Dictionary<string, long>();

            for (int i = 0; i < keys.Count(); i++)
            {
                if (soldierTypes[keys[i]].Keys.Contains(soldierType))
                {
                    if (!result.ContainsKey(keys[i]))
                    {
                        result.Add(keys[i], 0);
                    }
                    result[keys[i]] = soldierTypes[keys[i]][soldierType];
                }

            }

            result = result.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
        else
        {
            var keys = new List<string>();

            foreach (var kvp in soldierTypes)
            {
                foreach (var secondKvp in kvp.Value)
                {
                    if (secondKvp.Key == inputLine[0].Trim())
                    {
                        keys.Add(kvp.Key);
                    }
                }
            }

            var result = soldierActivities.Where(x => keys.Contains(x.Key)).OrderByDescending(x => x.Value);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Value} : {item.Key}");
            }
        }
    }
}

