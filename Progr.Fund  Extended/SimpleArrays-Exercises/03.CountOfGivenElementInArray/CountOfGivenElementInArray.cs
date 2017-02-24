using System;
using System.Linq;

public class CountOfGivenElementInArray
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().ToArray();
        var element = Console.ReadLine();
        var elementCount = numbers.Where(x => x == element).Count();

        Console.WriteLine(elementCount);
    }
}