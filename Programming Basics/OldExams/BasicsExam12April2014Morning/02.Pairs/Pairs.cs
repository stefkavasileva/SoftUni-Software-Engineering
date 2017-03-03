using System;
using System.Collections.Generic;
using System.Linq;

public class Pairs
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

        List<int> sums = new List<int>();

        for (int i = 0; i < nums.Length - 1; i += 2)
        {
            int sum = nums[i] + nums[i + 1];
            sums.Add(sum);
        }

        bool areEqualsSums = sums.Distinct().Count() == 1;

        if (areEqualsSums)
        {
            Console.WriteLine($"Yes, value={sums[0]}");
        }
        else
        {
            List<int> diffrence = new List<int>();

            for (int i = 0; i < sums.Count - 1; i++)
            {
                int num1 = sums[i];
                int num2 = sums[i + 1];
                int minNum = Math.Min(num1, num2);
                int maxNum = Math.Max(num1, num2);
                int diff = maxNum - minNum;
                diffrence.Add(diff);
            }

            Console.WriteLine($"No, maxdiff={diffrence.Max()}");
        }
    }
}