using System;

public class USDToBGN
{
    public static void Main(string[] args)
    {
        decimal usd = decimal.Parse(Console.ReadLine());
        decimal bgn = usd * 1.79549m;

        Console.WriteLine("{0:F2} BGN", bgn);
    }
}
