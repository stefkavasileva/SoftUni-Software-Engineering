using System;

public class Rocket
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dots = (3 * n - 2) / 2;
        int blankSpace = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}/{1}\\{0}",
                new string('.', dots),
                new string(' ', blankSpace));

            blankSpace += 2;
            dots--;
        }

        dots++;
        int asterisks = blankSpace;

        Console.WriteLine("{0}{1}{0}",
            new string('.', dots),
            new string('*', asterisks));

        asterisks -= 2;

        for (int i = 0; i < 2 * n; i++)
        {
            Console.WriteLine("{0}|{1}|{0}",
                new string('.', dots),
                new string('\\', asterisks));
        }

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}/{1}\\{0}",
                new string('.', dots),
                new string('*', asterisks));
            asterisks += 2;
            dots--;
        }
    }
}
