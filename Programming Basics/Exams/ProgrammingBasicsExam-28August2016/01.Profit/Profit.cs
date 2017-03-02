using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Profit
{
    static void Main(string[] args)
    {
        int workDays = int.Parse(Console.ReadLine());
        decimal moneyPerDay = decimal.Parse(Console.ReadLine());
        decimal unit = decimal.Parse(Console.ReadLine());

        decimal salary = workDays * moneyPerDay;
        decimal moneyPerYear = (salary * 12) + (salary * 2.5m);
        moneyPerYear -= moneyPerYear * 0.25m;

        decimal moneyInBG = moneyPerYear * unit;

        Console.WriteLine("{0:f2}", moneyInBG / 365.0m);
    }
}

