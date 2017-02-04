using System;

public class ExactProduct
{
    public static void Main()
    {
        int inputNums = int.Parse(Console.ReadLine());

        decimal sum = 1m;

        for (int i = 0; i < inputNums; i++)
        {
            sum *= decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}
