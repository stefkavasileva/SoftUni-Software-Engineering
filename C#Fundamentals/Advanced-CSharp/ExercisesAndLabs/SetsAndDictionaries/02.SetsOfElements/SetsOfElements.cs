using System;
using System.Collections.Generic;
using System.Linq;

public class SetsOfElements
{
    public static void Main()
    {
        var setsSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var firstSet = new HashSet<string>();
        var secondSet = new HashSet<string>();

        for (int i = 0; i < setsSizes[0]; i++)
        {
            firstSet.Add(Console.ReadLine());
        }

        for (int i = 0; i < setsSizes[1]; i++)
        {
            secondSet.Add(Console.ReadLine());
        }

        var intersection = firstSet.Intersect(secondSet);

        Console.WriteLine(string.Join(" ", intersection));
    }
}