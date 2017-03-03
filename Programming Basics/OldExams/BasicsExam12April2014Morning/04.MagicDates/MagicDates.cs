using System;
using System.Globalization;

public class MagicDates
{
    public static void Main()
    {
        DateTime startDate = DateTime.ParseExact("01-01-" + Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture); ;
        DateTime endDate = DateTime.ParseExact("31-12-" + Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        int megicWeight = int.Parse(Console.ReadLine());

        bool isMegicDate = false;

        for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        {
            int day = currentDate.Day;
            int dayDigit1 = (day / 10) % 10;
            int dayDigit2 = day % 10;

            int month = currentDate.Month;
            int monthDigit1 = (month / 10) % 10;
            int monthDigit2 = month % 10;

            int year = currentDate.Year;
            int yearDigit1 = (year / 1000) % 10;
            int yearDigit2 = (year / 100) % 10;
            int yearDigit3 = (year / 10) % 10;
            int yearDigit4 = year % 10;

            int[] digits = new int[] {
                dayDigit1, dayDigit2,
                monthDigit1, monthDigit2,
                yearDigit1, yearDigit2,
                yearDigit3, yearDigit4
            };

            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                for (int j = i + 1; j < digits.Length; j++)
                {
                    sum += digits[i] * digits[j];
                }
            }

            if (sum == megicWeight)
            {
                Console.WriteLine(currentDate.ToString("dd-MM-yyyy"));
                isMegicDate = true;
            }
        }

        if (!isMegicDate)
        {
            Console.WriteLine("No");
        }
    }
}
