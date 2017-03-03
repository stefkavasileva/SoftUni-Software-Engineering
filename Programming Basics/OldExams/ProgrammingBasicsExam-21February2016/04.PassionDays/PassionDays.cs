using System;

public class PassionDays
{
    public static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        string comand = Console.ReadLine();
        int count = 0;

        for (;;)
        {
            comand = Console.ReadLine();

            if (comand == "mall.Exit")
            {
                break;
            }

            for (int i = 0; i < comand.Length; i++)
            {
                decimal purchases = comand[i];

                if ((char)comand[i] >= 65 && (char)comand[i] <= 90 && money > 0)
                {
                    purchases = purchases - (purchases * 0.5m);
                }
                else if ((char)comand[i] >= 97 && (char)comand[i] <= 122 && money > 0)
                {
                    purchases = purchases - (purchases * 0.7m);
                }
                else if ((char)comand[i] == '%' && money > 0)
                {
                    purchases = money / 2.0m;
                }
                else if ((char)comand[i] == '*')
                {
                    money = money + 10m;
                    continue;

                }

                if (purchases > money)
                {
                    continue;
                }
                else
                {
                    money = money - purchases;
                    count++;
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No purchases. Money left: {0:f2} lv.", money);
        }
        else
        {
            Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", count, money);
        }
    }
}
