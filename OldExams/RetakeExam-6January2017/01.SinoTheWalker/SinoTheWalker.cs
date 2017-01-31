using System;
using System.Globalization;

public class SinoTheWalker
{
    public static void Main()
    {
        string leavesTimeAsStr = Console.ReadLine();

        DateTime leavesTime = DateTime.ParseExact(leavesTimeAsStr, "HH:mm:ss", CultureInfo.InvariantCulture);

        int steps = int.Parse(Console.ReadLine()) % 86400;
        int timeInSeconds = int.Parse(Console.ReadLine()) % 86400;

        int walkSeconds = steps * timeInSeconds;

        leavesTime = leavesTime.AddSeconds(walkSeconds);

        Console.WriteLine($"Time Arrival: {leavesTime.ToString("HH:mm:ss")}");
    }
}
