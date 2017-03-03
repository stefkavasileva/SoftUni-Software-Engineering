using System;
using System.Linq;

public class Electricity
{
    public static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flatsInFloor = int.Parse(Console.ReadLine());
        int[] time = Console.ReadLine().Split(':').Select(int.Parse).ToArray();

        int flats = floors * flatsInFloor;
        double totalElectricity = 0;

        int hour = time[0];

        if (hour >= 14 && hour <= 18)
        {
            totalElectricity = ((100.53 * 2) + (2 * 125.90)) * flats;
        }
        else if (hour >= 19 && hour <= 32)
        {
            totalElectricity = ((100.53 * 7) + (6 * 125.90)) * flats;
        }
        else if (hour >= 0 && hour <= 8)
        {
            totalElectricity = ((100.53 * 1) + (8 * 125.90)) * flats;
        }

        Console.WriteLine("{0} Watts", (int)totalElectricity);
    }
}
