using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FourFactors
{
    static void Main(string[] args)
    {
        decimal fG = decimal.Parse(Console.ReadLine());
        decimal fGA = decimal.Parse(Console.ReadLine());
        decimal threeP = decimal.Parse(Console.ReadLine());
        decimal tOV = decimal.Parse(Console.ReadLine());
        decimal oRB = decimal.Parse(Console.ReadLine());
        decimal oDRB = decimal.Parse(Console.ReadLine());
        decimal fT = decimal.Parse(Console.ReadLine());
        decimal fTA = decimal.Parse(Console.ReadLine());

        decimal efg = (fG + 0.5m * threeP) / fGA;
        decimal tov = (tOV) / (fGA + 0.44m * fTA + tOV);
        decimal orb = oRB / (oRB + oDRB);
        decimal ft = fT / fGA;

        Console.WriteLine("eFG% {0:f3}", efg);
        Console.WriteLine("TOV% {0:f3}", tov);
        Console.WriteLine("ORB% {0:f3}", orb);
        Console.WriteLine("FT% {0:f3}", ft);

    }
}

