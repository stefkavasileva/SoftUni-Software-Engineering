using System;
using System.Linq;

public class SumOfElements
{
    public static void Main()
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
