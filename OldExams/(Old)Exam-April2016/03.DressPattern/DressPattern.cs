using System;

public class DressPattern
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}.{0}.{0}", new string('_', 4 * n));

        int dashes = (4 * n) - 2;
        int asterisks = 2;
        for (int i = 0; i < 2 * n; i++)
        {
            Console.WriteLine("{0}.{1}.{0}.{1}.{0}", new string('_', dashes), new string('*', asterisks));

            dashes -= 2;
            asterisks += 3;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(".{0}.", new string('*', 12 * n));
        }

        Console.WriteLine("{0}{1}{0}", new string('.', 3 * n), new string('*', (12 * n + 2) - 2 * (3 * n)));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('_', 3 * n), new string('o', (12 * n + 2) - 2 * (3 * n)));
        }

        dashes = 3 * n;
        asterisks = 12 * n - (dashes * 2);

        for (int i = 0; i < 3 * n; i++)
        {
            Console.WriteLine("{0}.{1}.{0}", new string('_', dashes), new string('*', asterisks));

            dashes--;
            asterisks += 2;
        }

        Console.WriteLine("{0}", new string('.', 12 * n + 2));
    }
}
