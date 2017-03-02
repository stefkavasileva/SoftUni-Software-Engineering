using System;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int maxLength = -1;
        int endIndex = 0;
        int length = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                length++;
                if (i + 1 == numbers.Length - 1 && maxLength < length)
                {
                    maxLength = length;
                    endIndex = i + 1;
                }
            }
            else
            {
                if (maxLength < length)
                {
                    maxLength = length;

                    endIndex = i;
                }

                length = 0;
            }
        }

        PrintMaxSeqOfEqualElements(maxLength, endIndex, numbers);
    }

    private static void PrintMaxSeqOfEqualElements(int maxLength, int endIndex, int[] numbers)
    {
        for (int i = 0; i < maxLength + 1; i++)
        {
            Console.Write(numbers[endIndex] + " ");
        }
    }
}
