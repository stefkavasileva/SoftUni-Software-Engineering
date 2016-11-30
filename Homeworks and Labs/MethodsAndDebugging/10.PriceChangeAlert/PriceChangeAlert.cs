using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PriceChangeAlert
{
    static void Main(string[] args)
    {
        int numOfPrices = int.Parse(Console.ReadLine());
        double significance = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numOfPrices - 1; i++)
        {
            double price = double.Parse(Console.ReadLine());
            double diff = CalcPercentage(lastPrice, price);
            bool isDifference = IsDiffrence(diff, significance);

            string message = GetResult(price, lastPrice, diff, isDifference);
            Console.WriteLine(message);

            lastPrice = price;
        }
    }

    private static string GetResult(double price, double lastPrice, double diff, bool isDifference)
    {
        string message = string.Empty;
        if (diff == 0)
        {
            message = string.Format("NO CHANGE: {0}", price);
        }
        else if (!isDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, price, diff);
        }
        else if (isDifference && (diff > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, price, diff);
        }
        else if (isDifference && (diff < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, price, diff);
        }

        return message;
    }

    private static bool IsDiffrence(double diff, double significance)
    {
        if (Math.Abs(diff) >= significance)
        {
            return true;
        }
        return false;
    }

    private static double CalcPercentage(double lastPrice, double price)
    {
        double percentage = ((price - lastPrice) / lastPrice) * 100;
        return percentage;
    }


}

