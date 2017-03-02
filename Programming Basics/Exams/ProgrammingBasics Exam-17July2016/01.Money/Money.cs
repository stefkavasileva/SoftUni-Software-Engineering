using System;

public class Money
{
    public static void Main()
    {
        int bitcoins = int.Parse(Console.ReadLine());
        var yuans = double.Parse(Console.ReadLine());
        var commision = double.Parse(Console.ReadLine()) / 100.00;

        var bitcoinsInLeva = bitcoins * 1168.0;
        var yuansToDollars = yuans * 0.15;
        var dollarsToLeva = yuansToDollars * 1.76;

        var levas = bitcoinsInLeva + dollarsToLeva;
        var euros = levas / 1.95;
        euros -= commision * euros;

        Console.WriteLine(euros);
    }
}