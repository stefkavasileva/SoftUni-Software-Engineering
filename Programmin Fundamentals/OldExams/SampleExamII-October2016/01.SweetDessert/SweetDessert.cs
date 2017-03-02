using System;

public class SweetDessert
{
    public static void Main()
    {
        var amountOfCash = decimal.Parse(Console.ReadLine());
        var guestsCount = int.Parse(Console.ReadLine());

        var bananasPrice = decimal.Parse(Console.ReadLine());
        var eggsPrice = decimal.Parse(Console.ReadLine());
        var berriestPrice = decimal.Parse(Console.ReadLine());

        var portions = Math.Ceiling(guestsCount / 6.0m);
        var totalPrice = (portions * (2 * bananasPrice)) + (portions * (4 * eggsPrice)) + (portions * (0.2m * berriestPrice));

        if (amountOfCash >= totalPrice)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalPrice - amountOfCash):f2}lv more.");
        }
    }
}
