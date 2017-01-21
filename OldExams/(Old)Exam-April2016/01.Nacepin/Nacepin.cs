using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Nacepin
{
    static void Main(string[] args)
    {
        decimal priceUSStore = decimal.Parse(Console.ReadLine());
        long weightUSInKg = long.Parse(Console.ReadLine());
        decimal priceUKStore = decimal.Parse(Console.ReadLine());
        long weightUKInKg = long.Parse(Console.ReadLine());
        decimal priceChineseStore = decimal.Parse(Console.ReadLine());
        long weightChineseInKg = long.Parse(Console.ReadLine());

        decimal totalPriceFromUS = (priceUSStore / 0.58m) / weightUSInKg;
        decimal totalPriceFromUK = (priceUKStore / 0.41m) / weightUKInKg;
        decimal totalPriceFromCH = (priceChineseStore * 0.27m) / weightChineseInKg;

        if (totalPriceFromCH < totalPriceFromUK && totalPriceFromCH < totalPriceFromUS)
        {
            Console.WriteLine("Chinese store. {0:f2} lv/kg", totalPriceFromCH);

            decimal maxValue = Math.Max(totalPriceFromUK, totalPriceFromUS);
            decimal diff = maxValue - totalPriceFromCH;

            Console.WriteLine("Difference {0:f2} lv/kg", diff);
        }
        else if (totalPriceFromUK < totalPriceFromCH && totalPriceFromUK < totalPriceFromUS)
        {
            Console.WriteLine("UK store. {0:f2} lv/kg", totalPriceFromUK);

            decimal maxValue = Math.Max(totalPriceFromCH, totalPriceFromUS);
            decimal diff = maxValue - totalPriceFromUK;

            Console.WriteLine("Difference {0:f2} lv/kg", diff);
        }
        else if (totalPriceFromUS < totalPriceFromCH && totalPriceFromUS < totalPriceFromUK)
        {
            Console.WriteLine("US store. {0:f2} lv/kg", totalPriceFromUS);

            decimal maxValue = Math.Max(totalPriceFromUK, totalPriceFromCH);
            decimal diff = maxValue - totalPriceFromUS;

            Console.WriteLine("Difference {0:f2} lv/kg", diff);

        }
    }
}

