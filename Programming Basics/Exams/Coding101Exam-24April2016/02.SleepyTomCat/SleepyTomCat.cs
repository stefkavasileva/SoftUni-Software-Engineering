using System;

public class SleepyTomCat
{
    public static void Main()
    {
        int holidays = int.Parse(Console.ReadLine());

        int holidaysPlays = holidays * 127;
        int workdaysPlays = (365 - holidays) * 63;
        int totalPlays = holidaysPlays + workdaysPlays;

        int totalHoursPlays = Math.Abs((totalPlays - 30000) / 60);
        int totalMinutesPlays = Math.Abs((totalPlays - 30000) % 60);

        if (totalPlays > 30000)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", totalHoursPlays, totalMinutesPlays);
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", totalHoursPlays, totalMinutesPlays);
        }
    }
}
