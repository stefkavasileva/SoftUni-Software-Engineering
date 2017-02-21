using System;

public class TravelingAtLightSpeed
{
    public static void Main()
    {
        var lightYears = decimal.Parse(Console.ReadLine());

        var lightYearInKm = 9450000000000M;
        var speedOfLight = 300000M;

        var total = (lightYearInKm / speedOfLight) * lightYears;

        TimeSpan diff = TimeSpan.FromSeconds((double)total);

        Console.WriteLine($"{diff.Days / 7} weeks");
        Console.WriteLine($"{diff.Days % 7} days");
        Console.WriteLine($"{diff.Hours} hours");
        Console.WriteLine($"{diff.Minutes} minutes");
        Console.WriteLine($"{diff.Seconds} seconds");
    }
}