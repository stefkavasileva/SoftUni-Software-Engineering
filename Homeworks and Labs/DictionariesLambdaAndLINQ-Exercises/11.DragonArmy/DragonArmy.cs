using System;
using System.Collections.Generic;
using System.Linq;

public class DragonArmy
{
    public static void Main()
    {
        int dragonsCount = int.Parse(Console.ReadLine());

        var dragons = new Dictionary<string, SortedDictionary<string, int[]>>();

        for (int i = 0; i < dragonsCount; i++)
        {
            string[] lineArgs = Console.ReadLine().Split().ToArray();

            string dragonType = lineArgs[0];
            string dragonName = lineArgs[1];

            int damage = GetValue(lineArgs[2]) < 0 ? 45 : GetValue(lineArgs[2]);
            int health = GetValue(lineArgs[3]) < 0 ? 250 : GetValue(lineArgs[3]);
            int armor = GetValue(lineArgs[4]) < 0 ? 10 : GetValue(lineArgs[4]);
            int[] dragonState = new int[] { damage, health, armor };

            if (!dragons.ContainsKey(dragonType))
            {
                dragons.Add(dragonType, new SortedDictionary<string, int[]>());
            }

            if (!dragons[dragonType].ContainsKey(dragonName))
            {
                dragons[dragonType].Add(dragonName, new int[3]);
            }

            dragons[dragonType][dragonName][0] = damage;
            dragons[dragonType][dragonName][1] = health;
            dragons[dragonType][dragonName][2] = armor;
        }

        foreach (var dragonType in dragons)
        {
            var damageAverage = dragonType.Value.Select(x => x.Value[0]).ToArray().Average();
            var healthAverage = dragonType.Value.Select(x => x.Value[1]).ToArray().Average();
            var armorAverage = dragonType.Value.Select(x => x.Value[2]).ToArray().Average();

            Console.WriteLine($"{dragonType.Key}::({damageAverage:f2}/{healthAverage:f2}/{armorAverage:f2})");

            foreach (var dragon in dragonType.Value)
            {
                Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
            }
        }
    }

    private static int GetValue(string state)
    {
        try
        {
            return int.Parse(state);
        }
        catch (Exception)
        {
            return -1;
        }
    }
}
