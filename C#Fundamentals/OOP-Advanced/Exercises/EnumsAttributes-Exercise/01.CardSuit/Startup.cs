using System;

public class Startup
{
    public static void Main()
    {
        Console.WriteLine("Card Suits:");
        foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
        {
            Console.WriteLine($"Ordinal value: {(int)suit}; Name value: {suit}");
        }
    }
}

