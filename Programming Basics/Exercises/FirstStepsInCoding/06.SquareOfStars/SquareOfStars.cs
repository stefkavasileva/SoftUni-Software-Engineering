using System;

public class SquareOfStars
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', n));

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("*{0}*", new string(' ', n - 2));
        }

        Console.WriteLine(new string('*', n));
    }
}
