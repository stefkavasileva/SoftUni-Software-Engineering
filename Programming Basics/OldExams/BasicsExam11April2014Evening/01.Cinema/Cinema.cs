using System;

public class Cinema
{
    public static void Main()
    {
        string typeOfProjection = Console.ReadLine().ToLower();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        int totalSites = rows * cols;
        decimal tototalIncoms = 0m;

        if (typeOfProjection.Equals("premiere"))
        {
            tototalIncoms = totalSites * 12.00m;
        }
        else if (typeOfProjection.Equals("normal"))
        {
            tototalIncoms = totalSites * 7.50m;
        }
        else
        {
            tototalIncoms = totalSites * 5.0m;
        }

        Console.WriteLine($"{tototalIncoms:f2} leva");
    }
}
