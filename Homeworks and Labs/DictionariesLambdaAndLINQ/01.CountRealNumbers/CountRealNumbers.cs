using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountRealNumbers
{
    static void Main(string[] args)
    {
        double[] nums = Console.ReadLine().
            Split().Select(double.Parse).ToArray();

        SortedDictionary<double,int> numsCount = new SortedDictionary<double, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!numsCount.ContainsKey(nums[i]))
            {
                numsCount.Add(nums[i], 1);
            }
            else
            {
                numsCount[nums[i]]++;
            }
        }

        foreach (var num in numsCount)
        {
            Console.WriteLine($"{num.Key} -> {num.Value}");
        }

    }
}

