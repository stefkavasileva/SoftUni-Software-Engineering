using System;

public class Diamond
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int innerDots = 3 * n;
        int outerDots = n - 1;

        for (int i = 0; i < n + 1; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', n),
                    new string('*', 3 * n));
            }
            else if (i == n)
            {
                Console.WriteLine(new string('*', 5 * n));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', outerDots),
                    new string('.', innerDots));
                outerDots--;
                innerDots += 2;
            }
        }

        outerDots = 1;
        innerDots = (5 * n) - 4;

        for (int i = 0; i < 2 * n + 1; i++)
        {
            if (i == 2 * n)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', outerDots),
                    new string('*', innerDots));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
            }

            outerDots++;
            innerDots -= 2;
        }
    }
}
