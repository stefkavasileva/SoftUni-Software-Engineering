using System;
using System.Collections.Generic;
using System.Linq;

public class SequenceOfKNumbers
{
    public static void Main()
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        int k = int.Parse(Console.ReadLine());
        bool isEquals = true;

        for (int i = 0; i < nums.Count - (k - 1); i++)
        {
            for (int j = i; j < i + (k - 1); j++)
            {
                if (nums[j] == nums[j + 1])
                {
                    isEquals = true;
                    continue;
                }
                else
                {
                    isEquals = false;
                    break;
                }
            }

            if (isEquals)
            {
                nums.RemoveRange(i, k);
                i--;
            }
        }

        Console.WriteLine(string.Join(" ", nums));
    }
}