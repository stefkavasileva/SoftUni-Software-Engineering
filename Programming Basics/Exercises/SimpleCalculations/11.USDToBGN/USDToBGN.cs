using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class USDToBGN
{
    static void Main(string[] args)
    {
        decimal usd = decimal.Parse(Console.ReadLine());
        decimal bgn = usd * 1.79549m;

        Console.WriteLine("{0:F2} BGN",bgn);
    }
}

