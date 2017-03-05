using System;
using System.Collections.Generic;

public class CurrencyCheck
{
    public static void Main(string[] args)
    {
        decimal rubles = decimal.Parse(Console.ReadLine());
        decimal dollars = decimal.Parse(Console.ReadLine());
        decimal euro = decimal.Parse(Console.ReadLine());
        decimal levaB = decimal.Parse(Console.ReadLine());
        decimal levaM = decimal.Parse(Console.ReadLine());

        decimal rublesInBgn = (rubles / 100) * 3.5m;
        decimal dollarsInBgn = dollars * 1.5m;
        decimal euroInBG = euro * 1.95m;
        levaB /= 2;

       List<decimal> prices = new List<decimal>()
       {
           rublesInBgn,dollarsInBgn,euroInBG,levaB,levaM
       };
        prices.Sort();

        Console.WriteLine("{0:f2}", prices[0]);
    }
}