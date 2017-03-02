using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BookProblem
{
    static void Main(string[] args)
    {
        int bookPages = int.Parse(Console.ReadLine());
        int campingDayInMonth = int.Parse(Console.ReadLine());
        int readedPages = int.Parse(Console.ReadLine());

        double totalNeededMonths = bookPages / ((30.0 - campingDayInMonth) * readedPages);
        double neededYears = totalNeededMonths / 12.0;
        double neededMonths = totalNeededMonths % 12.0;

        if (neededMonths >= 0 && neededYears >= 0)
        {

            Console.WriteLine("{0} years {1} months", (int)neededYears, Math.Ceiling(neededMonths));
        }
        else
        {
            Console.WriteLine("never");
        }
    }
}

