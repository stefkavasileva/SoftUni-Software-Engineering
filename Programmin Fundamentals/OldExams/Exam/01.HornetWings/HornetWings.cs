using System;

public class HornetWings
{
    public static void Main()
    {
        var wingFlaps = int.Parse(Console.ReadLine());
        var distance = double.Parse(Console.ReadLine());
        var endurance = int.Parse(Console.ReadLine());

        var distanceInMeters = (wingFlaps / 1000) * distance;
        long seconds = (wingFlaps / endurance) * 5;
        seconds += wingFlaps / 100;

        Console.WriteLine($"{distanceInMeters:f2} m.");
        Console.WriteLine($"{seconds} s.");
    }
}

