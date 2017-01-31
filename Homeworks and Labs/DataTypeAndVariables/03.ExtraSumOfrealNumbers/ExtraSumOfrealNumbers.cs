using System;

public class ExtraSumOfrealNumbers
{
    public static void Main()
    {
        int inputNums = int.Parse(Console.ReadLine());

        decimal sum = 0M;

        for (int i = 0; i < inputNums; i++)
        {
            decimal currentRealNum = decimal.Parse(Console.ReadLine());
            sum += currentRealNum;
        }

        Console.WriteLine(sum);
    }
}
