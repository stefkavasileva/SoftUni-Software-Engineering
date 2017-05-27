using System;
using System.Collections.Generic;

public class PeriodicTable
{
    public static void Main()
    {
        var elementsCount = int.Parse(Console.ReadLine());
        var elements = new SortedSet<string>();

        for (int i = 0; i < elementsCount; i++)
        {
            var currentElements = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
              
            for (int j = 0; j < currentElements.Length; j++)
            {
                elements.Add(currentElements[j]);
            }         
        }

        Console.WriteLine(string.Join(" ",elements));
    }
}

