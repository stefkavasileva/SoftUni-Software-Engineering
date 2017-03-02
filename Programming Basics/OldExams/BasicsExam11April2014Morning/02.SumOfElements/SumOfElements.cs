using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumOfElements
{
    static void Main(string[] args)
    {
        long[] nums = Console.ReadLine().Split().Select(long.Parse).ToArray();

        long maxNum = nums.Max();
        long sumOFNums = nums.Sum() - maxNum;

        if (sumOFNums == maxNum)
        {
            Console.WriteLine($"Yes, sum={maxNum}");
        }
        else
        {
            long diff = Math.Abs(maxNum - sumOFNums);
            Console.WriteLine($"No, diff={diff}");
        }
    }
}

