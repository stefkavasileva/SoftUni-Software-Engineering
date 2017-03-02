using System;

public class ChangeTiles
{
    public static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double length = double.Parse(Console.ReadLine());
        double triangleSide = double.Parse(Console.ReadLine());
        double triangleHight = double.Parse(Console.ReadLine());
        double tilePrice = double.Parse(Console.ReadLine());
        double workmanMoney = double.Parse(Console.ReadLine());

        double floorArea = width * length;
        double tileArea = triangleHight * triangleSide / 2.0;
        int neededTiles = (int)Math.Ceiling(floorArea / tileArea) + 5;
        decimal total = (neededTiles * (decimal)tilePrice) + (decimal)workmanMoney;

        if (total <= money)
        {
            Console.WriteLine($"{money - total:f2} lv left.");
        }
        else
        {
            Console.WriteLine($"You'll need {total - money:f2} lv more.");
        }
    }
}
