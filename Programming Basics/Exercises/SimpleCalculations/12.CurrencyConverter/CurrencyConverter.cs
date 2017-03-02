using System;

public class CurrencyConverter
{
    public static void Main()
    {
        decimal currency = decimal.Parse(Console.ReadLine());
        string inputCurrency = Console.ReadLine().ToUpper();
        string outputCurrency = Console.ReadLine().ToUpper();

        if (inputCurrency == "USD")
        {
            currency = currency * 1.79549m;
        }
        else if (inputCurrency == "EUR")
        {
            currency = currency * 1.95583m;
        }
        else if (inputCurrency == "GBP")
        {
            currency = currency * 2.53405m;
        }

        if (outputCurrency == "USD")
        {
            currency = currency / 1.79549m;
        }
        else if (outputCurrency == "EUR")
        {
            currency = currency / 1.95583m;
        }
        else if (outputCurrency == "GBP")
        {
            currency = currency / 2.53405m;
        }

        Console.WriteLine("{0} {1}", Math.Round(currency, 2), outputCurrency.ToUpper());
    }
}