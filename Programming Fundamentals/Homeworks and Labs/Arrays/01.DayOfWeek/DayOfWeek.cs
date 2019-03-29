using System;

public class DayOfWeek
{
    public static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        if (day >= 1 & day <= 7)
        {
            Console.WriteLine(days[day - 1]);
        }
        else
        {
            Console.WriteLine("Invalid day");
        }
    }
}