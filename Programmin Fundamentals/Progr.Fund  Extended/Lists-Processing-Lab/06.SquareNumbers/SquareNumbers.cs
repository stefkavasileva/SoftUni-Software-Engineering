using System;
using System.Collections.Generic;
using System.Linq;

public class SquareNumbers
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> squareNumbers = new List<int>();

        foreach (var number in numbers)
        {
            double currentNum = Math.Sqrt(number);

            if (currentNum == (int)currentNum)
            {
                squareNumbers.Add(number);
            }
        }

        squareNumbers.Sort();
        squareNumbers.Reverse();

        Console.WriteLine(string.Join(" ", squareNumbers));
    }
}