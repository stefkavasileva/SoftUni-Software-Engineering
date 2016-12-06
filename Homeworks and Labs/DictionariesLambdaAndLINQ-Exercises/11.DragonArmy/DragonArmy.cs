using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DragonArmy
{
    static void Main(string[] args)
    {
        int numsOfDragons = int.Parse(Console.ReadLine());

        var dragons = new Dictionary<string, Dictionary<string, List<int>>>();

        for (int i = 0; i < numsOfDragons; i++)
        {
            string[] dragonArgs = Console.ReadLine()
                .Split().ToArray();

            string dragonType = dragonArgs[0];
            string dragonName = dragonArgs[1];
            int damage = GetValidDamageValue(dragonArgs);
            int health = GetValidHealthValue(dragonArgs);
            int armor = GetValidArmorValue(dragonArgs);

            List<int> dragonState = new List<int>
            {
                damage,health,armor
            };

            if (!dragons.ContainsKey(dragonType))
            {
                dragons[dragonType] = new Dictionary<string, List<int>>();
            }

            if (!dragons[dragonType].ContainsKey(dragonName))
            {
                dragons[dragonType].Add(dragonName, dragonState);
            }
            else
            {
                dragons[dragonType][dragonName] = dragonState;
            }

        }

        foreach (var dragonType in dragons)
        {
            double totalDamage = 0;
            double totalHealt = 0;
            double totalArmor = 0;
            int dragonsCount = 0;
            foreach (var dragon in dragonType.Value)
            {
                List<int> dragonState = dragon.Value.ToList();
                totalDamage += dragonState[0];
                totalHealt += dragonState[1];
                totalArmor += dragonState[2];
                dragonsCount++;
            }

            Console.Write($"{dragonType.Key}::");
            Console.Write($"({totalDamage / dragonsCount:f2}/");
            Console.Write($"{totalHealt / dragonsCount:f2}/");
            Console.WriteLine($"{totalArmor / dragonsCount:f2})");

            PrintDragonState(dragonType);
        }

    }

    private static void PrintDragonState(KeyValuePair<string, Dictionary<string, List<int>>> dragonType)
    {
        foreach (var dragon in dragonType.Value.OrderBy(x => x.Key))
        {
            Console.Write($"-{dragon.Key} -> ");
            Console.Write($"damage: {dragon.Value[0]}, ");
            Console.Write($"health: {dragon.Value[1]}, ");
            Console.WriteLine($"armor: {dragon.Value[2]}");
        }
    }

    private static int GetValidArmorValue(string[] dragonArgs)
    {
        int armor;
        if (dragonArgs[4] != "null")
        {
            armor = int.Parse(dragonArgs[4]);
        }
        else
        {
            armor = 10;
        }

        return armor;
    }

    private static int GetValidHealthValue(string[] dragonArgs)
    {
        int health;
        if (dragonArgs[3] != "null")
        {
            health = int.Parse(dragonArgs[3]);
        }
        else
        {
            health = 250;
        }

        return health;
    }

    private static int GetValidDamageValue(string[] dragonArgs)
    {
        int damage;
        if (dragonArgs[2] != "null")
        {
            damage = int.Parse(dragonArgs[2]);
        }
        else
        {
            damage = 45;
        }

        return damage;
    }
}

