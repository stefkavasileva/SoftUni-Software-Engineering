using System;
using System.Linq;

public class LargestThreeNumbers
{
    public static void Main()
    {
        double[] nums = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

        nums = nums
            .OrderByDescending(x => x)
            .Take(3)
            .ToArray();

        Console.WriteLine(string.Join(" ", nums));
    }
}