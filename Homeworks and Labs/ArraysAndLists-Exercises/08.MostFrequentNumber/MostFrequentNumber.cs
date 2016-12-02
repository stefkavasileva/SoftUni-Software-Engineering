using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MostFrequentNumber
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int maxLength = 0;
        int length = 0;
        int currentNum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            length = nums.Count(x => x==nums[i]);
            if (length>maxLength)
            {
                maxLength = length;
                currentNum = nums[i];
            }
        }

        Console.WriteLine(currentNum);
    }
}

