using System;

public class Startup
{
    public static void Main()
    {
        var firstDateAsStr = Console.ReadLine();
        var secondDateAsStr = Console.ReadLine();

        var result = DateModifier.GetDaysBeetwenTwoDate(firstDateAsStr, secondDateAsStr);
        Console.WriteLine(Math.Abs(result));
    }
}
