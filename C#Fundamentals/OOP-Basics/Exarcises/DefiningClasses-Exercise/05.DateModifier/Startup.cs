using System;

public class Startup
{
    public static void Main()
    {
        var firstDateAsStr = Console.ReadLine();
        var secondDateAsStr = Console.ReadLine();

        Console.WriteLine(DateModifier.GetDaysBetweenTwoDates(firstDateAsStr, secondDateAsStr));
    }
}
