using System;

public class Volleyball
{
    public static void Main()
    {
        string typeOfYear = Console.ReadLine().ToLower();
        int holidays = int.Parse(Console.ReadLine());
        int hometownWeekens = int.Parse(Console.ReadLine());

        double plays = (48 - hometownWeekens) * (3.0 / 4.0) + hometownWeekens + (holidays * 2 / 3.0);

        if (typeOfYear.Equals("leap"))
        {
            plays += plays * 0.15;
        }

        Console.WriteLine((int)plays);
    }
}