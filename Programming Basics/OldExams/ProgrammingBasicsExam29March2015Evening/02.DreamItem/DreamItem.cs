using System;
using System.Linq;

public class DreamItem
{
    public static void Main()
    {
        string[] inputArgs = Console.ReadLine().Split('\\').ToArray();
        string month = inputArgs[0];
        decimal moneyPerHour = decimal.Parse(inputArgs[1]);
        int hoursPerDay = int.Parse(inputArgs[2]);
        decimal priceOfTheIthem = decimal.Parse(inputArgs[3]);

        int daysInMonth = 0;

        switch (month)
        {
            case "Feb":
                daysInMonth = 28;
                break;
            case "Apr":
            case "June":
            case "Sept":
            case "Nov":
                daysInMonth = 30;
                break;
            default:
                daysInMonth = 31;
                break;
        }

        daysInMonth -= 10;
        decimal money = daysInMonth * moneyPerHour * hoursPerDay;

        if (money > 700)
        {
            money += money * 0.1m;
        }

        if (money >= priceOfTheIthem)
        {
            Console.WriteLine("Money left = {0:f2} leva.", money - priceOfTheIthem);
        }
        else
        {
            Console.WriteLine("Not enough money. {0:f2} leva needed.", priceOfTheIthem - money);
        }
    }
}