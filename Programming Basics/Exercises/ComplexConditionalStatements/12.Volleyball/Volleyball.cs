using System;

public class Volleyball
{
    public static void Main()
    {
        string typeOfYear = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int weekends = int.Parse(Console.ReadLine());

        double playsInSofia = (48 - weekends) * (3.0 / 4.0);
        double playsInBirthTown = weekends;
        double playsInHoliday = holidays * (2.0 / 3.0);

        double totalPlays = (playsInBirthTown + playsInHoliday + playsInSofia);

        if (typeOfYear == "leap")
        {
            totalPlays = (totalPlays + (totalPlays * 0.15));

        }

        Console.WriteLine(Math.Truncate(totalPlays));
    }
}
