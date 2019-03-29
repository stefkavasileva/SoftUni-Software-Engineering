using System;
using System.Collections.Generic;
using System.Linq;

public class Shellbound
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var regionShells = new Dictionary<string, HashSet<int>>();

        while (!inputLine.Equals("Aggregate"))
        {
            var tokens = inputLine.Split().ToArray();
            var regionName = tokens[0];
            var shell = int.Parse(tokens[1]);

            if (!regionShells.ContainsKey(regionName))
            {
                regionShells.Add(regionName, new HashSet<int>());
            }

            regionShells[regionName].Add(shell);

            inputLine = Console.ReadLine();
        }

        foreach (var region in regionShells)
        {
            var sumOfShells = region.Value.Sum();
            var countOfShells = region.Value.Count;

            var giantShell = GetGiantShel(sumOfShells, countOfShells);
            Console.WriteLine($"{region.Key} -> {string.Join(", ", region.Value)} ({giantShell})");
        }
    }

    public static int GetGiantShel(int sumOfShells, int countOfShells)
    {
        var giantShell = sumOfShells - (sumOfShells / countOfShells);
        return giantShell;
    }
}