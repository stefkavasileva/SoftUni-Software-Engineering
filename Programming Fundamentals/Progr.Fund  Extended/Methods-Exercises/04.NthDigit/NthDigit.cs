using System;
using System.Collections.Generic;
using System.Linq;

public class NthDigit
{
    public static void Main()
    {
        var numberAsStr = Console.ReadLine().ToCharArray().Reverse().ToList();
        var index = int.Parse(Console.ReadLine());

        var nthDigit = FindNthDigit(numberAsStr, index);

        Console.WriteLine(nthDigit);
    }

    private static char FindNthDigit(List<char> numberAsStr, int index)
    {
        return numberAsStr[index - 1];
    }
}