using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CondenseArrayToNumber
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int i = 0;
        while (nums.Length > 1)
        {
            int[] condensed = new int[nums.Length - 1];
            while (i != condensed.Length)
            {
                condensed[i] = nums[i] + nums[i + 1];
                i++;

            }
            nums = condensed;
            i = 0;
        }

        Console.WriteLine(nums[0]);
    }
}

