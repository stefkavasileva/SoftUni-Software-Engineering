using System;
using System.Collections.Generic;
using System.Linq;

public class SumAdjacentEqualNumbers
{
    public static void Main()
    {
        List<double> numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToList();

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            double firstNum = numbers[i];
            double secondNum = numbers[i + 1];

            if (firstNum == secondNum)
            {
                numbers[i] = 2 * numbers[i];
                numbers.RemoveAt(i + 1);
                i -= 2;

                if (i < -1)
                {
                    i = -1;
                }
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
