using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class JumpingSums
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int jumps = int.Parse(Console.ReadLine());

        long maxSum = 0;
        int nextIndex = 0;
        long sum = 0;
        for (int index = 0; index < nums.Length; index++)
        {
            int currentIndex = index;
            sum = nums[currentIndex];

            for (int j = 0; j < jumps; j++)
            {
                nextIndex = (currentIndex + nums[currentIndex]) % nums.Length;
                sum += nums[nextIndex];
                currentIndex = nextIndex;
            }

            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }

        Console.WriteLine("max sum = {0}", maxSum);
    }
}

