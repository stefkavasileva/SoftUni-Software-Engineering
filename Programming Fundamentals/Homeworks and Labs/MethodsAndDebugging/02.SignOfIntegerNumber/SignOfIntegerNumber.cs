using System;

public class SignOfIntegerNumber
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        PrintSign(number);
    }

    private static void PrintSign(int number)
    {
        if (number < 0)
        {
            Console.WriteLine($"The number {number} is negative.");
        }
        else if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else
        {
            Console.WriteLine($"The number {number} is zero.");
        }
    }
}
