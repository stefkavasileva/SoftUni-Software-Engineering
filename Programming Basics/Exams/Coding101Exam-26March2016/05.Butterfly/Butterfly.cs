using System;

public class Butterfly
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int topRows = n - 2;
        int bottomRows = n - 2;

        for (int i = 0; i < topRows; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0}\\ /{0}",
                    new string('*', n - 2));
            }
            else
            {
                Console.WriteLine("{0}\\ /{0}",
                   new string('-', n - 2));
            }
        }

        Console.WriteLine("{0}@{0}", new string(' ', n - 1));

        for (int i = 0; i < bottomRows; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0}/ \\{0}",
                    new string('*', n - 2));
            }
            else
            {
                Console.WriteLine("{0}/ \\{0}",
                   new string('-', n - 2));
            }
        }
    }
}
