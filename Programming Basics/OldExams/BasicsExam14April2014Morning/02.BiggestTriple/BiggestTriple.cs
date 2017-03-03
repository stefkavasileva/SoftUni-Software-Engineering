using System;
using System.Linq;

public class BiggestTriple
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int sum = 0;
        int bigestSum = int.MinValue;
        int startIndex = 0;
        int remainder = numbers.Length % 3;

        for (int i = 0; i < numbers.Length; i += 3)
        {
            if (i == numbers.Length - remainder && remainder == 2)
            {
                sum = numbers[i] + numbers[i + 1];
            }
            else if (i == numbers.Length - remainder && remainder == 1)
            {
                sum = numbers[i];
            }
            else
            {
                sum = numbers[i] + numbers[i + 1] + numbers[i + 2];
            }

            if (sum > bigestSum)
            {
                bigestSum = sum;
                startIndex = i;
            }
        }

        if (remainder == 2 && startIndex + 2 == numbers.Length)
        {
            Console.WriteLine("{0} {1}",
                numbers[startIndex],
                numbers[startIndex + 1]);
        }
        else if (remainder == 1 && startIndex + 1 == numbers.Length)
        {
            Console.WriteLine("{0}",
                numbers[startIndex]);
        }
        else
        {
            Console.WriteLine("{0} {1} {2}",
                numbers[startIndex],
                numbers[startIndex + 1],
                numbers[startIndex + 2]);
        }
    }
}
