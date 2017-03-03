using System;

public class Dumbbell
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dots = ((n - 1) / 2) - 1;
        int asterisks = (n - 1) / 2;

        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == n)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('.', (n - 1) / 2),
                    new string('&', (n + 1) / 2),
                    new string('.', n));
            }
            else
            {
                if (i > 1 && i < (n + 1) / 2)
                {
                    Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                         new string('.', dots),
                         new string('*', asterisks),
                         new string('.', n));

                    dots--;
                    asterisks++;
                }
                else if (i == (n + 1) / 2)
                {
                    Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                         new string('.', dots),
                         new string('*', asterisks),
                         new string('=', n));
                    dots = 1;
                    asterisks -= 1;
                }
                else
                {
                    Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                        new string('.', dots),
                        new string('*', asterisks),
                        new string('.', n));
                    dots++;
                    asterisks--;
                }
            }
        }
    }
}