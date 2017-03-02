using System;

public class RadiansToDegrees
{
    public static void Main()
    {
        double radians = double.Parse(Console.ReadLine());
        double degrees = Math.Round((radians * 180) / Math.PI, 2);

        Console.WriteLine(degrees);
    }
}
