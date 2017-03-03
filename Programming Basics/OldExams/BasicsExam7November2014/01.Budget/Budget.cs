using System;

public class Budget
{
    public static void Main()
    {
        decimal amountMoney = decimal.Parse(Console.ReadLine());
        int weekdayPerMonth = int.Parse(Console.ReadLine());
        int weekendInHome = int.Parse(Console.ReadLine());

        decimal spendMoneyWeekends = (8 - weekendInHome * 2) * 20.0m;
        decimal weeksdaysGoingOut = weekdayPerMonth * (Math.Floor((amountMoney * 0.03m)) + 10.0m);
        decimal normalWeekdays = (22 - weekdayPerMonth) * 10.0m;
        decimal totalMoneySpend = spendMoneyWeekends + weeksdaysGoingOut + normalWeekdays + 150.0m;

        decimal leftMoney = amountMoney - totalMoneySpend;

        if (leftMoney > 0)
        {
            Console.WriteLine("Yes, leftover {0}.", (int)leftMoney);
        }
        else if (leftMoney < 0)
        {
            Console.WriteLine("No, not enough {0}.", (int)totalMoneySpend - amountMoney);
        }
        else
        {
            Console.WriteLine("Exact Budget.");
        }
    }
}
