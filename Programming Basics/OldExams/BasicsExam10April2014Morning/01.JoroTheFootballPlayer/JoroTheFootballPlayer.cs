using System;

public class JoroTheFootballPlayer
{
    public static void Main()
    {
        char yearType = char.Parse(Console.ReadLine());
        int holidays = int.Parse(Console.ReadLine());
        int homeTownWeek = int.Parse(Console.ReadLine());

        int plays = (int)((52 - homeTownWeek) * 2 / 3.0 + (homeTownWeek) + (holidays * 1 / 2.0));

        if (yearType == 't')
        {
            plays += 3;
        }

        Console.WriteLine(plays);
    }
}