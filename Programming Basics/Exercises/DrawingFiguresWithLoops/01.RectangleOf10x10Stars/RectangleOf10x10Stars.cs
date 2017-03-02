using System;

public class RectangleOf10x10Stars
{
    public static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(new string('*', 10));
        }
    }
}
