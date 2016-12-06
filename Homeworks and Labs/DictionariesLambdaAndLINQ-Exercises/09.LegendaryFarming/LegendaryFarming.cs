using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LegendaryFarming
{
    static void Main(string[] args)
    {
        string[] materialsArgs = Console.ReadLine()
            .ToLower().Split().ToArray();
        Dictionary<string, int> materials = new Dictionary<string, int>();

        materials.Add("shards", 0);
        materials.Add("fragments", 0);
        materials.Add("motes", 0);
        int count = 0;
        while (count != 10)
        {
            string legendary = string.Empty;

            for (int i = 0; i < materialsArgs.Length; i += 2)
            {
                int materialsCount = int.Parse(materialsArgs[i]);

                if (!materials.ContainsKey(materialsArgs[i + 1]))
                {
                    materials.Add(materialsArgs[i + 1], 0);
                }

                materials[materialsArgs[i + 1]] += materialsCount;

                legendary = HasLegendary(materials);

                if (legendary != string.Empty)
                {            
                    break;
                }
            }

            if (legendary != string.Empty)
            {
                Console.WriteLine($"{legendary} obtained!");
                break;
            }

            materialsArgs = Console.ReadLine()
            .ToLower().Split().ToArray();
            count++;
        }


        var keyMaterials = materials.Take(3).OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
        var junkMaterials = materials.Skip(3).OrderBy(x => x.Key).ToList();

        foreach (var item in keyMaterials)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        foreach (var item in junkMaterials)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

    }

    private static string HasLegendary(Dictionary<string, int> materials)
    {
        string legendary = string.Empty;
        if (materials["shards"] >= 250)
        {
            materials["shards"] -= 250;
            legendary = "Shadowmourne";
        }
        else if (materials["fragments"] >= 250)
        {
            materials["fragments"] -= 250;
            legendary = "Valanyr";
        }
        else if (materials["motes"] >= 250)
        {
            materials["motes"] -= 250;
            legendary = "Dragonwrath";
        }

        return legendary;
    }
}

