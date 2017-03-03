using System;

public class FitBoxInBox
{
    public static void Main()
    {
        int w1 = int.Parse(Console.ReadLine());
        int h1 = int.Parse(Console.ReadLine());
        int d1 = int.Parse(Console.ReadLine());
        int w2 = int.Parse(Console.ReadLine());
        int h2 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());

        if (w1 < w2 && h1 < h2 && d1 < d2)
        {
            Console.WriteLine($"({w1}, {h1}, {d1}) < ({w2}, {h2}, {d2})");
        }

        if (w1 < w2 && h1 < d2 && d1 < h2)
        {
            Console.WriteLine($"({w1}, {h1}, {d1}) < ({w2}, {d2}, {h2})");
        }

        if (w1 < h2 && h1 < w2 && d1 < d2)
        {
            Console.WriteLine($"({w1}, {h1}, {d1}) < ({h2}, {w2}, {d2})");
        }

        if (w1 < h2 && h1 < d2 && d1 < w2)
        {
            Console.WriteLine($"({w1}, {h1}, {d1}) < ({h2}, {d2}, {w2})");
        }

        if (w1 < d2 && h1 < w2 && d1 < h2)
        {
            Console.WriteLine($"({w1}, {h1}, {d1}) < ({d2}, {w2}, {h2})");
        }

        if (w1 < d2 && h1 < h2 && d1 < w2)
        {
            Console.WriteLine($"({w1}, {h1}, {d1}) < ({d2}, {h2}, {w2})");
        }

        if (w2 < w1 && h2 < h1 && d2 < d1)
        {
            Console.WriteLine($"({w2}, {h2}, {d2}) < ({w1}, {h1}, {d1})");
        }

        if (w2 < w1 && h2 < d1 && d2 < h1)
        {
            Console.WriteLine($"({w2}, {h2}, {d2}) < ({w1}, {d1}, {h1})");
        }
        if (w2 < h1 && h2 < w1 && d2 < d1)
        {
            Console.WriteLine($"({w2}, {h2}, {d2}) < ({h1}, {w1}, {d1})");
        }

        if (w2 < h1 && h2 < d1 && d2 < w1)
        {
            Console.WriteLine($"({w2}, {h2}, {d2}) < ({h1}, {d1}, {w1})");
        }

        if (w2 < d1 && h2 < w1 && d2 < h1)
        {
            Console.WriteLine($"({w2}, {h2}, {d2}) < ({d1}, {w1}, {h1})");
        }

        if (w2 < d1 && h2 < h1 && d2 < w1)
        {
            Console.WriteLine($"({w2}, {h2}, {d2}) < ({d1}, {h1}, {w1})");
        }
    }
}