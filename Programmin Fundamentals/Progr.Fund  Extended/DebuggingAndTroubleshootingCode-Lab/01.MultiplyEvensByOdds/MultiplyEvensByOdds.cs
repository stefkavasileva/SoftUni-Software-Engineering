using System;
using System.Linq;

public class MultiplyEvensByOdds
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .ToCharArray()
            .Where(x => char.IsDigit(x))
            .Select(x => (int)char.GetNumericValue(x))          
            .ToArray();

        var evenCount = numbers.Where(x => x % 2 == 0).Sum();
        var oddCount = numbers.Where(x => x % 2 != 0).Sum();

        Console.WriteLine(evenCount * oddCount);
    }
}

