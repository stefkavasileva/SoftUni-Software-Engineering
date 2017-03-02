using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargestProductOfDigits
{
    static void Main(string[] args)
    {
        char[] inputNums = Console.ReadLine().ToCharArray();
        int[] nums = Array.ConvertAll(inputNums, c => (int)char.GetNumericValue(c));

        int maxSum = int.MinValue;

        for (int i = 0; i <= nums.Length - 6; i++)
        {
            int sum = nums[i] * nums[i + 1] * nums[i + 2] * nums[i + 3] * nums[i + 4] * nums[i + 5];

            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }

        Console.WriteLine(maxSum);
    }
}

