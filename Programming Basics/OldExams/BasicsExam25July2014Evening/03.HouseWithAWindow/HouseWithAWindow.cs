using System;

public class HouseWithAWindow
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('.', n - 1));

        int outerDots = n - 2;
        int innterDots = 1;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', outerDots),
                new string('.', innterDots));

            outerDots--;
            innterDots += 2;
        }

        Console.WriteLine(new string('*', (2 * n) - 1));

        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("*{0}*", new string('.', (2 * n) - 3));
        }

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("*{0}{1}{0}*",
                new string('.', n / 2),
                new string('*', n - 3));
        }

        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("*{0}*", new string('.', (2 * n) - 3));
        }

        Console.WriteLine(new string('*', (2 * n) - 1));
    }
}