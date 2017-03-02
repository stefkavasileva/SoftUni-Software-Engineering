using System;
using System.Linq;

public class MinMaxSumAverage
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            nums[i] = num;
        }

        int sum = nums.Sum();
        int min = nums.Min();
        int max = nums.Max();
        int firstNum = nums.First();
        int lastNum = nums.Last();
        double average = nums.Average();

        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Min = {min}");
        Console.WriteLine($"Max = {max}");
        Console.WriteLine($"Average = {average}");
    }
}
