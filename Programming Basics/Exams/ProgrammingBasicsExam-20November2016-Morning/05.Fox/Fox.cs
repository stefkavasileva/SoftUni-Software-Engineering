using System;

public class Fox
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int asterisks = 1;
        int dashes = ((2 * n) + 3) - 4;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}",
                new string('*', asterisks),
                new string('-', dashes));

            asterisks++;
            dashes -= 2;
        }

        int innerAsterisks = n;
        asterisks = ((2 * n) + 3) - (n + 4);
        asterisks /= 2;

        for (int i = 0; i < n / 3; i++)
        {
            Console.WriteLine("|{0}\\{1}/{0}|",
                new string('*', asterisks),
                new string('*', innerAsterisks));
            innerAsterisks -= 2;
            asterisks++;

        }

        dashes = 1;
        asterisks = ((2 * n) + 3) - 4;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}\\{1}/{0}",
                new string('-', dashes),
                new string('*', asterisks));

            dashes++;
            asterisks -= 2;
        }
    }
}
