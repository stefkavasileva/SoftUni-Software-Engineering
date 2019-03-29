using System;
using System.Globalization;

public class DayOfWeek
{
    public static void Main()
    {
        string dataAsStr = Console.ReadLine();
        DateTime date = DateTime.ParseExact(dataAsStr, "d-M-yyyy", CultureInfo.InvariantCulture);
        string dayOfWeek = date.DayOfWeek.ToString();
        Console.WriteLine(dayOfWeek);
    }
}