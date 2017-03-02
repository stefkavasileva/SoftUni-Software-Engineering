using System;
using System.Globalization;

public class _1000DaysAfterBirth
{
    public static void Main()
    {
        string birthday = Console.ReadLine();

        DateTime date = DateTime.ParseExact(birthday, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        date = date.AddDays(999);

        Console.WriteLine("{0}", date.ToString("dd-MM-yyyy"));
    }
}
