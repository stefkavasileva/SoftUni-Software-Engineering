using System;

public class ConvertSpeedUnits
{
    public static void Main()
    {
        float distanceInMeters = float.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        float hoursInMinutes = hours * 60.0f;
        float minInseconds = (minutes + hoursInMinutes) * 60.0f;
        float totoalSeconds = minInseconds + seconds;

        float metersPerSeconds = distanceInMeters / totoalSeconds;
        float kmPerH = (distanceInMeters / 1000.0f) / (totoalSeconds / 3600.0f);
        float milesPerH = (distanceInMeters / 1609.0f) / (totoalSeconds / 3600.0f);

        Console.WriteLine(metersPerSeconds);
        Console.WriteLine(kmPerH);
        Console.WriteLine(milesPerH);
    }
}
