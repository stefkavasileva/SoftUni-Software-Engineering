using System;

public class Startup
{
    public static void Main()
    {
        string input = Console.ReadLine();

        var gandalf = new Gandalf();

        var foods = FoodFactory.ProduceFood(input);
        MoodFactory.ChangeMood(gandalf, foods);

        Console.WriteLine(gandalf);
    }
}

