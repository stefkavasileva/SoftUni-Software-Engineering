using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestIncreasingSubsequence
{
    static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine().
            Split().Select(int.Parse).ToList();

        int[] length = new int[nums.Count];
        int[] prev = new int[nums.Count];
        int maxLength = 0;
        int lastIndex = -1;

        for (int i = 0; i < nums.Count; i++)
        {
            length[i] = 1;
            prev[i] = -1;

            for (int j = 0; j < i; j++)
            {
                if (nums[j] < nums[i] && length[j] >= length[i])
                {
                    length[i] = 1 + length[j];
                    prev[i] = j;
                }
            }

            if (length[i] > maxLength)
            {
                maxLength = length[i];
                lastIndex = i;
            }
        }

        List<int> longestSeq = new List<int>();

        for (int i = 0; i < maxLength; i++)
        {
            longestSeq.Add(nums[lastIndex]);
            lastIndex = prev[lastIndex];
        }

        longestSeq.Reverse();

        Console.WriteLine(string.Join(" ",longestSeq));
    }
}

