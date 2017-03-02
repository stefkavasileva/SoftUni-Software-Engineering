using System;

public class CharityMarathon
{
   public static void Main()
    {
        var marathonLength = int.Parse(Console.ReadLine());
        var runnersCount = int.Parse(Console.ReadLine());
        var laps = int.Parse(Console.ReadLine());
        var lengthOfTrack = int.Parse(Console.ReadLine());
        var capacityOfTrack = int.Parse(Console.ReadLine());
        var amountOfMoneyPerKm = decimal.Parse(Console.ReadLine());

        long runnersToBeRun = Math.Min((capacityOfTrack * marathonLength),runnersCount);
        long totalMeters = runnersToBeRun * laps * lengthOfTrack;
        var totalKm = totalMeters / 1000;

        var moneyForMarathon = totalKm * amountOfMoneyPerKm;

        Console.WriteLine($"Money raised: {moneyForMarathon:f2}");
    }
}
