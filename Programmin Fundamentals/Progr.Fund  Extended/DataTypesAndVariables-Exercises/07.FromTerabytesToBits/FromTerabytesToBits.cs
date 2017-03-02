using System;

public class FromTerabytesToBits
{
    public static void Main()
    {
        var tb = decimal.Parse(Console.ReadLine());
        var tbToBit = tb * 1024 * 1024 * 1024 * 1024 * 8;

        Console.WriteLine("{0:f0}", tbToBit);
    }
}