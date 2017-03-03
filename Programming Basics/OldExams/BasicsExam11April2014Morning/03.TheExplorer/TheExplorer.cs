using System;

public class TheExplorer
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}",
            new string('-', n / 2));

        int outerDashes = (n / 2) - 1;
        int innerDashes = 1;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('-', outerDashes),
                new string('-', innerDashes));

            outerDashes--;
            innerDashes += 2;
        }

        outerDashes = 1;
        innerDashes = n - 4;

        for (int i = 0; i < (n / 2) - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
               new string('-', outerDashes),
               new string('-', innerDashes));

            outerDashes++;
            innerDashes -= 2;
        }

        Console.WriteLine("{0}*{0}",
           new string('-', n / 2));
    }
}
