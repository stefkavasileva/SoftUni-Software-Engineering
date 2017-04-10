using System;
using System.Collections.Generic;
using System.Linq;

public class MinMaxSumAverage
{
    public static void Main()
    {
        var count = int.Parse(Console.ReadLine());
        var numers = new List<int>();

        for (int i = 0; i < count; i++)
        {
            var currentNumber = int.Parse(Console.ReadLine());
            numers.Add(currentNumber);
        }

        Console.WriteLine($"Sum = {numers.Sum()}");
        Console.WriteLine($"Min = {numers.Min()}");
        Console.WriteLine($"Max = {numers.Max()}");
        Console.WriteLine($"Average = {numers.Average()}");
    }
}

