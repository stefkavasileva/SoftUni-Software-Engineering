using System;

public class SweetDessert
{
    public static void Main()
    {
        decimal amountOfCash = decimal.Parse(Console.ReadLine());
        long guests = long.Parse(Console.ReadLine());
        decimal bananasPrice = decimal.Parse(Console.ReadLine());
        decimal eggsPrice = decimal.Parse(Console.ReadLine());
        decimal berriesPrice = decimal.Parse(Console.ReadLine());

        decimal sets = (int)guests / 6;

        if (guests % 6 != 0)
        {
            sets += 1;
        }

        decimal neededBananas = sets * (2.0m * bananasPrice);
        decimal neededEggs = sets * (4.0m * eggsPrice);
        decimal neededBerries = sets * (0.2m * berriesPrice);

        decimal totalNeededCash = neededBananas + neededBerries + neededEggs;

        if (totalNeededCash <= amountOfCash)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {totalNeededCash:f2}lv.");
        }
        else
        {
            decimal diff = totalNeededCash - amountOfCash;
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {diff:f2}lv more.");
        }
    }
}
