using System;
using System.Linq;

public class RoundingNumbers
{
    public static void Main()
    {
        string inputLine = Console.ReadLine();
        double[] nums = inputLine.Split(' ').Select(double.Parse).ToArray();

        for (int i = 0; i < nums.Length; i++)
        {
            double num = nums[i];
            int roundedNum = (int)Math.Round(num, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{num} => {roundedNum}");
        }

    }
}
