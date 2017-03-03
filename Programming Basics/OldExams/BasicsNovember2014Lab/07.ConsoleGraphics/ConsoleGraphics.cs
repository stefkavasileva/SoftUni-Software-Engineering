using System;

public class ConsoleGraphics
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintTop(n);
        PrintMiddle(n);
        PrintBottom(n);
    }

    public static void PrintBottom(int n)
    {
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(new string('~', 2 * n));
        }
    }

    public static void PrintMiddle(int n)
    {
        int asterisks = ((2 * n) - (n - 1)) / 2;

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('*', asterisks),
                new string(' ', n - 1));
        }
    }

    public static void PrintTop(int n)
    {
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
