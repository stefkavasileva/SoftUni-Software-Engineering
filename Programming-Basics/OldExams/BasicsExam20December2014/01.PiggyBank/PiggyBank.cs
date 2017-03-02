using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PiggyBank
{
    static void Main(string[] args)
    {
        int tankPrice = int.Parse(Console.ReadLine());
        int partydaysInMonth = int.Parse(Console.ReadLine());

        double spendPerMonth = partydaysInMonth * 5;
        double savePerMonth = ((30 - partydaysInMonth) * 2) - spendPerMonth;

        int neededMonth = (int)Math.Ceiling(tankPrice / savePerMonth);

        int years = neededMonth / 12;
        int month = neededMonth % 12;

        if (month <= 0 && years <= 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            Console.WriteLine($"{years} years, {month} months");
        }

    }
}

