using System;

public class SweetDessert
{
    public static void Main()
    {
        decimal amountOfCash = decimal.Parse(Console.ReadLine());
        int guests = int.Parse(Console.ReadLine());
        decimal bananaPrice = decimal.Parse(Console.ReadLine());
        decimal eggsPrice = decimal.Parse(Console.ReadLine());
        decimal berriesPriceForKg = decimal.Parse(Console.ReadLine());

        int portions = (int)Math.Ceiling(guests / 6.0);

        decimal totalBananaPrice = portions * (2 * bananaPrice);
        decimal totalEggsPrice = portions * (4 * eggsPrice);
        decimal totalBerriesPrice = portions * (0.2m * berriesPriceForKg);

        decimal totalPrice = totalBananaPrice + totalBerriesPrice + totalEggsPrice;

        if (totalPrice <= amountOfCash)
        {
            Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", totalPrice);
        }
        else
        {
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", totalPrice - amountOfCash);
        }
    }
}
