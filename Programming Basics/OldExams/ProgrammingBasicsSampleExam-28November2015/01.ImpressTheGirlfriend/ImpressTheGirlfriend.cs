using System;

public class ImpressTheGirlfriend
{
    public static void Main()
    {
        decimal rubles = decimal.Parse(Console.ReadLine());
        decimal dollars = decimal.Parse(Console.ReadLine());
        decimal euro = decimal.Parse(Console.ReadLine());
        decimal siteB = decimal.Parse(Console.ReadLine());
        decimal siteM = decimal.Parse(Console.ReadLine());

        decimal russianSite = (rubles / 100m) * 3.5m;
        decimal americanSite = dollars * 1.5m;
        decimal euroSite = euro * 1.95m;
        decimal oneGameFromSiteB = siteB / 2;
        decimal[] prices = { russianSite, americanSite, euroSite, oneGameFromSiteB, siteM };
        decimal mostExpensive = 0.0m;

        for (int i = 0; i < prices.Length; i++)
        {
            decimal price = prices[i];
            if (price > mostExpensive)
            {
                mostExpensive = price;
            }
        }

        Console.WriteLine("{0:f2}", Math.Ceiling(mostExpensive));
    }
}
