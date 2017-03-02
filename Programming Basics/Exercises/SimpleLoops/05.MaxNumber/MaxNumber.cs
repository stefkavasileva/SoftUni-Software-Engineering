using System;

public class MaxNumber
{
    public static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int maxNum = int.MinValue;

        for (int i = 0; i < numbers; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > maxNum)
            {
                maxNum = num;
            }
        }

        Console.WriteLine(maxNum);
    }
}