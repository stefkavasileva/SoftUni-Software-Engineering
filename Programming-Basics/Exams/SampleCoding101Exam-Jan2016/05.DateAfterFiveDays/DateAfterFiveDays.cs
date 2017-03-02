using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DateAfterFiveDays
{
    static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());

        string dataAsStr = day + "." + month + "." + "2015";
        DateTime date = DateTime.ParseExact(dataAsStr, "d.M.yyyy", CultureInfo.InvariantCulture);
        date = date.AddDays(5);

        Console.WriteLine(date.ToString("d.MM"));
    }
}

