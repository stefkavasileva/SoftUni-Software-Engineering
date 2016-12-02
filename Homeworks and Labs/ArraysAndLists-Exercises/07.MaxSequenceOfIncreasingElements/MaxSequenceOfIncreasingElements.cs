using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxSequenceOfIncreasingElements
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int length = 1;
        int digit = 0;
        int maxLength = 1;

        GetMaxLength(nums, ref length, ref digit, ref maxLength);

        digit -=maxLength-1;

        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(digit + " ");
            digit++;
        }
    }

    private static void GetMaxLength(int[] nums, ref int length, ref int digit, ref int maxLength)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] < nums[i + 1])
            {
                length++;

                if (i == nums.Length - 2)
                {
                    if (length > maxLength)
                    {
                        maxLength = length;
                        digit = nums[i + 1];
                    }
                }
            }
            else
            {
                if (length > maxLength)
                {
                    maxLength = length;
                    digit = nums[i];
                }

                length = 1;
            }
        }
    }
}

