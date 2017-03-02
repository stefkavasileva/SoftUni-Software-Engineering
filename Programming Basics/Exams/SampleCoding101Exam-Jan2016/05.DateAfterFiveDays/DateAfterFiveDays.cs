using System;
using System.Globalization;

public class DateAfterFiveDays
{
    public static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());

        string dataAsStr = day + "." + month + "." + "2015";
        DateTime date = DateTime.ParseExact(dataAsStr, "d.M.yyyy", CultureInfo.InvariantCulture);
        date = date.AddDays(5);

        Console.WriteLine(date.ToString("d.MM"));
    }
}
