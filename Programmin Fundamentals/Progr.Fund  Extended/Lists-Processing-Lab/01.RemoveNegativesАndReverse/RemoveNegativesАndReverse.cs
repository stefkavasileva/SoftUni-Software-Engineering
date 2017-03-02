using System;
using System.Linq;

public class RemoveNegativesАndReverse
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        var positiveNumbers = numbers.Where(x => x >= 0).ToList();
        positiveNumbers.Reverse();

        var result = positiveNumbers.Count() == 0 ? "empty" : string.Join(Environment.NewLine, positiveNumbers);
        Console.Write(result);
    }
}