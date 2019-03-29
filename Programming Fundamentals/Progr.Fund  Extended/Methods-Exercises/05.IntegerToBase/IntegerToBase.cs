using System;

public class IntegerToBase
{
    public static void Main()
    {
        var num = long.Parse(Console.ReadLine());
        var @base = int.Parse(Console.ReadLine());

        var result = IntegerToCurrentBase(num, @base);

        Console.WriteLine(result);
    }

    public static string IntegerToCurrentBase(long num, int @base)
    {
        var result = string.Empty;
        while (num != 0)
        {
            var remainder = num % @base;
            result = remainder + result;
            num /= @base;
        }

        return result;
    }
}