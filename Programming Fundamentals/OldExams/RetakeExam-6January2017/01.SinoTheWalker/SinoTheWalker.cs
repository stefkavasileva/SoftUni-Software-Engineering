using System;
using System.Globalization;

public class SinoTheWalker
{
    public static void Main()
    {
        var timeLeaves = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InstalledUICulture);
        var steps = int.Parse(Console.ReadLine()) % 86400;
        var timeForStep = int.Parse(Console.ReadLine()) % 86400;

        var stepsTime = steps * timeForStep;
        var timeArrival = timeLeaves.AddSeconds(stepsTime);

        Console.WriteLine($"Time Arrival: {timeArrival.ToString("HH:mm:ss")}");
    }
}
