using System;
using System.Collections.Generic;
using System.Linq;

public class HalfSum
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> firstNums = new List<int>();
        List<int> secondNums = new List<int>();

        for (int i = 0; i < n * 2; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (i >= n)
            {
                firstNums.Add(num);
            }
            else
            {
                secondNums.Add(num);
            }
        }

        int firstSum = firstNums.Sum();
        int secondSum = secondNums.Sum();

        if (firstSum == secondSum)
        {
            Console.WriteLine($"Yes, sum={firstSum}");
        }
        else
        {
            Console.WriteLine($"No, diff={Math.Abs(firstSum - secondSum)}");
        }
    }
}
