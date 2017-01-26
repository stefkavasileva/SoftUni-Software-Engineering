using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RoundingNumbers
{
    static void Main(string[] args)
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

