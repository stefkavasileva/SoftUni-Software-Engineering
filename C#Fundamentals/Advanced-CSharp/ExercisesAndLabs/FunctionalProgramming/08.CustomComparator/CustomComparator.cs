using System;
using System.Linq;

public class CustomComparator
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        var evenNums = numbers.FindAll(delegate (int num)
        {
            return num % 2 == 0;
        });

        evenNums.Sort();

        var oddNums = numbers.FindAll(delegate (int num)
        {
            return num % 2 != 0;
        });

        oddNums.Sort();

        var result = evenNums.Concat(oddNums);
        Console.WriteLine(string.Join(" ", result));
    }
}

