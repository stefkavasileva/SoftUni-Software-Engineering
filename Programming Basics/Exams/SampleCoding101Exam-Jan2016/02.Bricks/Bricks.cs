using System;

public class Bricks
{
    public static void Main()
    {
        double x = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        double result = x / (workers * m);

        Console.WriteLine(Math.Ceiling(result));
    }
}
