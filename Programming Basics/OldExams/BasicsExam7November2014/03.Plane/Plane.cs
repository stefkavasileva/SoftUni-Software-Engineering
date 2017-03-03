using System;

public class Plane
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = (((n * 3) - 3) / 2);
        int innerDots = 1;
        int outerDouts2 = n - 4;
        int innerDosts2 = 1;
        int endDots = n;
        int segment1 = ((n * 3) - (n / 2)) - (n + n - 2);
        int segmen2 = (n + 1) - segment1;
        int segmet3 = ((n * 3) - (n / 2)) - (n + segment1 + segmen2);
        int segment4 = n;

        Console.WriteLine("{0}*{0}",
                    new string('.', (((n * 3) - 1) / 2)));
        for (int i = 1; i < segment1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', outerDots),
                new string('.', innerDots));
            outerDots--;
            innerDots += 2;
        }

        for (int i = 1; i <= segmen2; i++)
        {
            if (i == 1)
            {
                outerDots--;
                innerDots += 2;
            }
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', outerDots),
                new string('.', innerDots));
            outerDots -= 2;
            innerDots += 4;
        }

        for (int i = 1; i <= segmet3; i++)
        {
            if (i == 1)
            {
                Console.WriteLine("*{0}*{1}*{0}*",
                    new string('.', n - 2),
                    new string('.', n));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                    new string('.', outerDouts2),
                    new string('.', innerDosts2),
                    new string('.', n));
                outerDouts2 -= 2;
                innerDosts2 += 2;
            }
        }

        for (int i = 1; i <= n; i++)
        {
            if (i == n)
            {
                Console.WriteLine("{0}",
                    new string('*', 3 * n));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', innerDosts2 + 1),
                    new string('.', endDots));
                innerDosts2--;
                endDots += 2;
            }
        }
    }
}