using System;

public class FloatOrInteger
{
    public static void Main()
    {
        var number = double.Parse(Console.ReadLine());

        var result = (int)Math.Round(number);

        Console.WriteLine(result);
    }
}