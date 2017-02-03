using System;
using System.Collections.Generic;
using System.Linq;

public class CountRealNumbers
{
    public static void Main()
    {
        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

        var realNumCount = new SortedDictionary<double, int>();

        foreach (var num in numbers)
        {
            if (!realNumCount.ContainsKey(num))
            {
                realNumCount.Add(num, 0);
            }

            realNumCount[num]++;
        }

        foreach (var num in realNumCount)
        {
            Console.WriteLine($"{num.Key} -> {num.Value}");
        }
    }
}