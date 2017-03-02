using System;

public class SumNumbers
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int sumOfNums = 0;

        for (int i = 0; i < number; i++)
        {
            int num = int.Parse(Console.ReadLine());
            sumOfNums += num;
        }

        Console.WriteLine(sumOfNums);
    }
}