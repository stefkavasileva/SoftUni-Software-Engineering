using System;

public class MagicWand
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int outerDots = ((3 * n + 2) - 3) / 2;
        int innerDots = 1;
        int dots = ((3 * n + 2) - 1) / 2;

        Console.WriteLine("{0}*{0}", new string('.', dots));

        for (int i = 1; i <= n / 2 + 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
            outerDots--;
            innerDots += 2;
        }

        Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', n + 2));

        outerDots = 1;
        innerDots = (3 * n + 2) - 4;

        for (int i = 1; i <= (n - 1) / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
            outerDots++;
            innerDots -= 2;
        }

        outerDots -= 2;
        innerDots = n / 2;
        int middleDots = n;
        int innerDots2 = 0;

        for (int i = 1; i <= (n + 1) / 2; i++)
        {
            if (outerDots == -1)
            {
                Console.WriteLine("{0}*{1}*{2}*{1}{0}*",
               new string('*', innerDots),
               new string('.', innerDots2),
               new string('.', middleDots));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}",
                   new string('.', outerDots),
                   new string('.', innerDots),
                   new string('.', innerDots2),
                   new string('.', middleDots));
            }

            outerDots--;
            innerDots2++;
        }

        for (int i = 1; i <= n + 1; i++)
        {
            if (i == n + 1)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n), new string('*', n));
            }
            else
            {
                Console.WriteLine("{0}*{0}*{0}", new string('.', n));
            }
        }
    }
}

