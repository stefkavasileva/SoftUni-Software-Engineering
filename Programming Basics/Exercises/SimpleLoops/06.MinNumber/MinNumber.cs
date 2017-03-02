using System;

public class MinNumber
{
    public static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int minNum = int.MaxValue;

        for (int i = 0; i < numbers; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < minNum)
            {
                minNum = num;
            }
        }

        Console.WriteLine(minNum);
    }
}