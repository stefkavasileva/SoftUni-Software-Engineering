using System;

public class DrawFigure
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dots = 0;
        int asterisks = n;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('.', dots),
                new string('*', asterisks));

            dots++;
            asterisks -= 2;
        }

        asterisks = 1;
        dots = (n - 1) / 2;

        for (int i = 0; i < (n / 2) + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('.', dots),
                new string('*', asterisks));

            dots--;
            asterisks += 2;
        }
    }
}