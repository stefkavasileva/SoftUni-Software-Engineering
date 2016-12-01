using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractMiddleElements
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        string result = GetMiddleElements(nums);

        Console.WriteLine(result);

    }

    private static string GetMiddleElements(int[] nums)
    {
        string result = string.Empty;
        if (nums.Length == 1)
        {
            result = "{ " + nums[0] + " }";
            return result;
        }
        else if (nums.Length % 2 == 0)
        {
            result = "{ " + nums[(nums.Length / 2) - 1] + ", " + nums[nums.Length / 2] + " }";
            return result;
        }
        else
        {
            result = "{ " + nums[(nums.Length / 2) - 1] + ", " + nums[nums.Length / 2] + ", " + nums[(nums.Length / 2) + 1] + " }";
            return result;
        }
    }
}

