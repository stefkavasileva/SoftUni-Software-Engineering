using System;
using System.Linq;

public class SmallestElementInArray
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        var minNumber = numbers.Min();
        Console.WriteLine(minNumber);
    }
}
