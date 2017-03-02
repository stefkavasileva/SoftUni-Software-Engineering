using System;
using System.Collections.Generic;
using System.Linq;

public class LongestIncreasingSubsequence
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int[] len = new int[numbers.Count];
        int[] prev = new int[numbers.Count];

        int maxLength = 0;
        int lastIndex = -1;

        for (int i = 0; i < numbers.Count; i++)
        {
            len[i] = 1;
            prev[i] = -1;
            for (int j = 0; j <= i; j++)
            {
                if (numbers[j] < numbers[i] && len[j] + 1 > len[i])
                {
                    len[i] = len[j] + 1;
                    prev[i] = j;
                }

                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }
        }

        List<int> longesSubSeq = new List<int>();

        while (lastIndex != -1)
        {
            longesSubSeq.Add(numbers[lastIndex]);
            lastIndex = prev[lastIndex];
        }

        longesSubSeq.Reverse();

        Console.WriteLine(string.Join(" ", longesSubSeq));
    }
}
