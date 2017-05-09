using System;
using System.Collections.Generic;
using System.Linq;

public class FindEvensOrOdds
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var numberType = Console.ReadLine();

        var evenNums = new List<int>();
        var oddNums = new List<int>();

        for (int i = numbers[0]; i <= numbers[1]; i++)
        {
            if (isEven(i, n => n % 2 == 0))
            {
                evenNums.Add(i);
            }
            else
            {
                oddNums.Add(i);
            }
        }

        var result = numberType.Equals("even") ? 
            string.Join(" ", evenNums) : 
            string.Join(" ", oddNums);

        Console.WriteLine(result);

    }

    public static bool isEven(int number, Func<int, bool> condition)
    {
        return condition(number);
    }
}

