using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _1000DaysAfterBirth
{
    static void Main(string[] args)
    {
        string birthday = Console.ReadLine();

        DateTime date = DateTime.ParseExact(birthday, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        date = date.AddDays(999);

        Console.WriteLine("{0}", date.ToString("dd-MM-yyyy"));
    }
}

