using System;

public class ChristmasTree
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} | ", new string(' ', n));

        for (int row = 1; row <= n; row++)
        {
            Console.WriteLine("{0}{1} | {1}{0}",
                new string(' ', n - row),
                new string('*', row));
        }
    }
}
