using System;
using System.Collections.Generic;
using System.Linq;

public class DragonArmy
{
    public static void Main()
    {
        var dragonsCount = int.Parse(Console.ReadLine());

        var dragons = new Dictionary<string, List<Dragon>>();

        for (int i = 0; i < dragonsCount; i++)
        {
            var lineArgs = Console.ReadLine().Split().ToArray();

            var dragonType = lineArgs[0];
            var dragonName = lineArgs[1];

            var damage = lineArgs[2].Equals("null") ? 45 : int.Parse(lineArgs[2]);
            var health = lineArgs[3].Equals("null") ? 250 : int.Parse(lineArgs[3]);
            var armor = lineArgs[4].Equals("null") ? 10 : int.Parse(lineArgs[4]);

            if (!dragons.ContainsKey(dragonType))
            {
                dragons.Add(dragonType, new List<Dragon>());
            }

            if (!dragons[dragonType].Any(x => x.Name == dragonName))
            {
                var dragon = new Dragon(dragonName);
                dragons[dragonType].Add(dragon);
            }

            dragons[dragonType].First(x => x.Name == dragonName).Health = health;
            dragons[dragonType].First(x => x.Name == dragonName).Damage = damage;
            dragons[dragonType].First(x => x.Name == dragonName).Armor = armor;
        }

        foreach (var dragonType in dragons)
        {
            var damageAverage = dragonType.Value.Select(x => x.Damage).ToArray().Average();
            var healthAverage = dragonType.Value.Select(x => x.Health).ToArray().Average();
            var armorAverage = dragonType.Value.Select(x => x.Armor).ToArray().Average();

            Console.WriteLine($"{dragonType.Key}::({damageAverage:f2}/{healthAverage:f2}/{armorAverage:f2})");

            var currentDragons = dragonType.Value.OrderBy(x => x.Name);

            foreach (var dragon in currentDragons)
            {
                Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
            }
        }
    }
}
