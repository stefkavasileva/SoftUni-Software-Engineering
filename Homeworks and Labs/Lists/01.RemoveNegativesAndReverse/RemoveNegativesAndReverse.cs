using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveNegativesAndReverse
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> positiveNumbers = numbers.Where(x => x >= 0).Reverse().ToList();

        if (positiveNumbers.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ", positiveNumbers));
        }
    }
}
