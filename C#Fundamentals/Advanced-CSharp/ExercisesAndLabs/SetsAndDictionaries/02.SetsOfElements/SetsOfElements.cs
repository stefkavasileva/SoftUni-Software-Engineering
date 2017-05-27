using System;
using System.Collections.Generic;
using System.Linq;

public class SetsOfElements
{
    public static void Main()
    {
        var size = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var firstNumbers = new HashSet<int>();
        var secondNumbers = new HashSet<int>();
        AddNumbers(size[0], firstNumbers);
        AddNumbers(size[1], secondNumbers);

        var result = firstNumbers.Intersect(secondNumbers);

        Console.WriteLine(string.Join(" ",result));

    }

    private static void AddNumbers(int size, HashSet<int> numbers)
    {
        for (int i = 0; i < size; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }
    }
}