using System;
using System.Globalization;

public class HolidaysBetweenTwoDates
{
    public static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

        var holidaysCount = 0;

        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday ||
                date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
        }

        Console.WriteLine(holidaysCount);
    }
}
