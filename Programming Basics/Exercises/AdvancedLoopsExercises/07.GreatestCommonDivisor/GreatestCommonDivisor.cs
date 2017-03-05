using System;

public class GreatestCommonDivisor
{
    public static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        int remainder = 0;

        while (num2 != 0)
        {
            remainder = num1 % num2;
            num1 = num2;
            num2 = remainder;
        }

        Console.WriteLine(num1);
    }
}
