using System;

public class Flowers
{
    public static void Main()
    {
        int chrysanthemums = int.Parse(Console.ReadLine());
        int roses = int.Parse(Console.ReadLine());
        int tulips = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        bool isHoliday = Console.ReadLine() == "Y" ? true : false;

        decimal chrysanthemumsPrice = 0.0m;
        decimal rosesPrice = 0.0m;
        decimal tulipsPrice = 0.0m;

        if (season.Equals("Spring") || season.Equals("Summer"))
        {
            chrysanthemumsPrice = chrysanthemums * 2m;
            rosesPrice = roses * 4.1m;
            tulipsPrice = tulips * 2.5m;
        }
        else
        {
            chrysanthemumsPrice = chrysanthemums * 3.75m;
            rosesPrice = roses * 4.5m;
            tulipsPrice = tulips * 4.15m;
        }

        decimal bouquetPrice = chrysanthemumsPrice + rosesPrice + tulipsPrice;

        if (isHoliday)
        {
            bouquetPrice += bouquetPrice * 0.15m;
        }

        if (tulips > 7 && season.Equals("Spring"))
        {
            bouquetPrice -= bouquetPrice * 0.05m;
        }

        if (roses >= 10 && season.Equals("Winter"))
        {
            bouquetPrice -= bouquetPrice * 0.1m;
        }

        if (roses + tulips + chrysanthemums > 20)
        {
            bouquetPrice -= bouquetPrice * 0.2m;
        }

        bouquetPrice += 2;

        Console.WriteLine($"{bouquetPrice:f2}");
    }
}
