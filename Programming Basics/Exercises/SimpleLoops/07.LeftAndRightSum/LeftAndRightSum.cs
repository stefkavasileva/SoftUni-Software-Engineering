using System;

public class LeftAndRightSum
{
    public static void Main()
    {
        int nums = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < 2 * nums; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (i < nums)
            {
                leftSum += num;
            }
            else
            {
                rightSum += num;
            }
        }

        if (rightSum == leftSum)
        {
            Console.WriteLine($"Yes, sum = {leftSum}");
        }
        else
        {
            int diff = Math.Abs(leftSum - rightSum);

            Console.WriteLine($"No, diff = {diff}");
        }
    }
}