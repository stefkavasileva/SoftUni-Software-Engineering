using System;
using System.Globalization;

namespace _10.DateModifier
{
    public class DateModifier
    {
        public static long GetDaysBeetwenTwoDate(string firstDateAsStr, string secondDateAsStr)
        {
            var firstDate = DateTime.ParseExact(firstDateAsStr, "yyyy MM dd", CultureInfo.InvariantCulture);
            var secondDate = DateTime.ParseExact(secondDateAsStr, "yyyy MM dd", CultureInfo.InvariantCulture);
            var result = (secondDate - firstDate).TotalDays;
            return (long)result;
        }
    }
}
