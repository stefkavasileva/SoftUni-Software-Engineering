using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GrandTheftExamo
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        long slaped = 0;
        long escape = 0;
        long totalBeers = 0;

        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (t > 5)
            {
                escape += t - 5;
                slaped += 5;
            }
            else
            {
                slaped += t;
            }

            totalBeers += b;
        }

        Console.WriteLine("{0} thieves slapped.", slaped);
        Console.WriteLine("{0} thieves escaped.", escape);

        long beerPacks = totalBeers / 6;
        long bears = totalBeers % 6;

        Console.WriteLine("{0} packs, {1} bottles.", beerPacks, bears);
    }
}

