using System;

public class Startup
{
    public static void Main()
    {
        var count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            var element = new Box<string>(Console.ReadLine());
            Console.WriteLine(element);
        }
    }
}

