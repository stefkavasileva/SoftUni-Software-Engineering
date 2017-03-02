using System;

public class Cinema
{
    public static void Main()
    {
        string typeProection = Console.ReadLine().ToLower();
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        int sites = row * col;
        decimal profit = 0;

        if (typeProection == "premiere")
        {
            profit = sites * 12.00m;
        }
        else if (typeProection == "normal")
        {
            profit = sites * 7.50m;
        }
        else
        {
            profit = sites * 5.00m;
        }

        Console.WriteLine("{0:F2} leva", profit);
    }
}