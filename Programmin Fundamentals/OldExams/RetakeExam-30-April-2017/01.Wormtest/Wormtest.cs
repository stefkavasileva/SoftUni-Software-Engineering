using System;

public class Wormtest
{
    public static void Main()
    {
        var lengthInM = long.Parse(Console.ReadLine());
        var widthInCm = double.Parse(Console.ReadLine());

        var lengthInCm = lengthInM * 100.0;

        var remainder = (lengthInCm % widthInCm);

        if (widthInCm == 0)
        {
            var result = lengthInCm * widthInCm;
            Console.WriteLine($"{result:f2}");
            return;
        }

        if (remainder != 0)
        {
            var result = (lengthInCm / widthInCm) * 100.0;
            Console.WriteLine($"{result:f2}%");
        }
        else
        {
            var result = lengthInCm * widthInCm;
            Console.WriteLine($"{result:f2}");
        }
    }
}
