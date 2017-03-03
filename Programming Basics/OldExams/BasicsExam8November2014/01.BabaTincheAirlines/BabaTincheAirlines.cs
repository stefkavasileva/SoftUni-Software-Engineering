using System;
using System.Linq;

public class BabaTincheAirlines
{
    public static void Main()
    {
        int[] firstClassInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] businessClassInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] economyClassInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int firstClassIncome = (int)((firstClassInfo[0] - firstClassInfo[1]) * 7000) +
             (int)(firstClassInfo[1] * (7000 - (7000 * 0.7m))) + (int)(firstClassInfo[2] * (7000 * 0.005m));

        int businessClassIncome = (int)((businessClassInfo[0] - businessClassInfo[1]) * 3500) +
            (int)(businessClassInfo[1] * (3500 - (3500 * 0.7m))) + (int)(businessClassInfo[2] * (3500 * 0.005m));

        int economyClassIncome = (int)((economyClassInfo[0] - economyClassInfo[1]) * 1000m) +
            (int)(economyClassInfo[1] * (1000 - (1000 * 0.7m))) + (int)(economyClassInfo[2] * (1000 * 0.005m));

        int maxIncomeFirstClass = (12 * 7000) + (int)(12 * (7000 * 0.005m));
        int maxIncomeBusinessClass = (28 * 3500) + (int)(28 * (3500 * 0.005m));
        int maxIncomeEconomyClass = (50 * 1000) + (int)(50 * (1000 * 0.005m));

        decimal totalIncome = firstClassIncome + businessClassIncome + economyClassIncome;
        decimal maxIncome = maxIncomeBusinessClass + maxIncomeEconomyClass + maxIncomeFirstClass;

        Console.WriteLine((int)totalIncome);
        Console.WriteLine((int)maxIncome - (int)totalIncome);
    }
}