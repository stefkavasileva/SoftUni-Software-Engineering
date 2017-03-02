using System;
using System.Collections.Generic;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int bestLenght = 0;
        int startIndex = 0;
        int count = 1;

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                count++;
                if (i == numbers.Count - 2 && count > bestLenght)
                {
                    bestLenght = count;
                    startIndex = i;
                }
            }
            else
            {
                if (count > bestLenght)
                {
                    bestLenght = count;
                    startIndex = i;
                }

                count = 1;
            }
        }

        Console.WriteLine(string.Concat(Enumerable.Repeat($"{numbers[startIndex]} ", bestLenght)));
    }
}
