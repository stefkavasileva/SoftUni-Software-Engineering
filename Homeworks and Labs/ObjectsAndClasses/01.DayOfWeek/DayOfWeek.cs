using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DayOfWeek
{
    static void Main(string[] args)
    {
        string dataAsStr = Console.ReadLine();
        DateTime date = DateTime.ParseExact(dataAsStr, "d-M-yyyy", CultureInfo.InvariantCulture);
        string dayOfWeek = date.DayOfWeek.ToString();
        Console.WriteLine(dayOfWeek);
    }
}


