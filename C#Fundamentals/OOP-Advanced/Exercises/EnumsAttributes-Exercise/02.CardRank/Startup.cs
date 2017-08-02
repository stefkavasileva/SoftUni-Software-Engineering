using System;

public class Startup
{
    public static void Main()
    {
        Console.WriteLine("Card Ranks:");
        foreach (CardRank suit in Enum.GetValues(typeof(CardRank)))
        {
            Console.WriteLine($"Ordinal value: {(int)suit}; Name value: {suit}");
        }
    }
}

