using System;

public class SmartLilly
{
    public static void Main()
    {
        int lillysAge = int.Parse(Console.ReadLine());
        decimal laundryPrice = decimal.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        decimal lillysMoney = 0;
        decimal birthayMoney = 10;

        for (int i = 1; i <= lillysAge; i++)
        {
            if (i % 2 == 0)
            {
                lillysMoney += birthayMoney - 1;
                birthayMoney += 10;
            }
            else
            {
                lillysMoney += toyPrice;
            }
        }

        decimal result = Math.Abs(lillysMoney - laundryPrice);

        if (lillysMoney >= laundryPrice)
        {
            Console.WriteLine("Yes! {0:f2}", result);
        }
        else
        {
            Console.WriteLine("No! {0:f2}", result);
        }
    }
}
