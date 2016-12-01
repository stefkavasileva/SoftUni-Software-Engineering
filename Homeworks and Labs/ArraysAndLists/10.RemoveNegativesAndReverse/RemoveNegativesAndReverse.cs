using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RemoveNegativesAndReverse
{
    static void Main(string[] args)
    {
        int [] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

        nums = RemoveNegativeNum(nums);
        Array.Reverse(nums);

        if (nums.Length==0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ",nums));
        }
    }

    private static int[] RemoveNegativeNum(int[] nums)
    {
       nums= nums.Select(x => x).Where(x => x > 0).ToArray();
        return nums;
    }
}

