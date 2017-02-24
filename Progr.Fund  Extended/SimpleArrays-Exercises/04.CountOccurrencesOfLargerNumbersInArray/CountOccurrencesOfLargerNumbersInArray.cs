using System;
using System.Linq;

public class CountOccurrencesOfLargerNumbersInArray
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var element = double.Parse(Console.ReadLine());
        var elementCount = numbers.Where(x => x > element).Count();

        Console.WriteLine(elementCount);
    }
}
