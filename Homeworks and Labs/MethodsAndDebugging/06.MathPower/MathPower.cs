using System;

public class MathPower
{
    public static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());

        double result = ReiseToPower(num, power);

        Console.WriteLine(result);
    }

    private static double ReiseToPower(double num, int power)
    {
        double result = num;
        for (int i = 0; i < power - 1; i++)
        {
            result *= num;
        }

        return result;
    }
}
