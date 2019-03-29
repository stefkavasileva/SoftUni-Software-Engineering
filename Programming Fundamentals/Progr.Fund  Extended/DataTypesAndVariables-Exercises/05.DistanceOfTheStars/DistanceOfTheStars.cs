using System;

public class DistanceOfTheStars
{
    public static void Main()
    {
        var proxima = 4.22m * 9460000000000m;
        var milkyWay = 26000M * 9450000000000m;
        var radiusMilkyWay = 100000M * 9450000000000m;
        var distanceEarth = 46500000000M * 9450000000000M;

        Console.WriteLine(proxima.ToString("e2"));
        Console.WriteLine(milkyWay.ToString("e2"));
        Console.WriteLine(radiusMilkyWay.ToString("e2"));
        Console.WriteLine(distanceEarth.ToString("e2"));
    }
}