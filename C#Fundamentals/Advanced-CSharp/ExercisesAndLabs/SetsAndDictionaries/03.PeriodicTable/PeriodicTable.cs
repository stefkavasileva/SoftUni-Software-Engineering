using System;
using System.Collections.Generic;

public class PeriodicTable
{
    public static void Main()
    {
        var chemicalElements = new SortedSet<string>();

        var count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            var currentElements = Console.ReadLine().Split();
            foreach (var element in currentElements)
            {
                chemicalElements.Add(element);
            }           
        }

        Console.WriteLine(string.Join(" ", chemicalElements));
    }
}

