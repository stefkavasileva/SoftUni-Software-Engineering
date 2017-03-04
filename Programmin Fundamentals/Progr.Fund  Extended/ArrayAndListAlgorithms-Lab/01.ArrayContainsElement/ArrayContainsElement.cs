using System;
using System.Linq;

public class ArrayContainsElement
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        var number = int.Parse(Console.ReadLine());

        var isContains = numbers.Contains(number);
        var result = isContains ? "yes" : "no";

        Console.WriteLine(result);
    }
}
