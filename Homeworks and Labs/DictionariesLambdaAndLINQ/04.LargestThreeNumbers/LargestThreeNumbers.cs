using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargestThreeNumbers
{
    static void Main(string[] args)
    {
        double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

        nums = nums.OrderByDescending(x => x).Take(3).ToArray();
        Console.WriteLine(string.Join(" ", nums));
    }
}

