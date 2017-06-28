using System;
using System.Globalization;

public static class DateModifier
{
    public static long GetDaysBetweenTwoDates(string firstDateAsStr, string secondDateAsStr)
    {
        var firstDate = DateTime.ParseExact(firstDateAsStr, "yyyy MM dd", CultureInfo.InvariantCulture);
        var secondDate = DateTime.ParseExact(secondDateAsStr, "yyyy MM dd", CultureInfo.InvariantCulture);

        return Math.Abs((firstDate - secondDate).Days);
    }
}

