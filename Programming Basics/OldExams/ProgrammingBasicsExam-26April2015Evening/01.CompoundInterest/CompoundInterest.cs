using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompoundInterest
{
    static void Main(string[] args)
    {
        decimal tvPrice = decimal.Parse(Console.ReadLine());
        double term = double.Parse(Console.ReadLine());
        decimal rateBank = decimal.Parse(Console.ReadLine());
        decimal rateFriend = decimal.Parse(Console.ReadLine());

        double d = Math.Pow((1.0 + (double)rateBank), term);
        decimal bank = tvPrice * (decimal)d;
        decimal friend = tvPrice * (1.0m + rateFriend);

        if (friend <= bank)
        {
            Console.WriteLine("{0:f2} Friend", friend);
        }
        else
        {
            Console.WriteLine("{0:f2} Bank", bank);
        }
    }
}

