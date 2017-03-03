using System;

public class Boat
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = n - 1;
        int asterisks = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i >= 1 && i <= (n + 1) / 2)
            {
                Console.WriteLine("{0}{1}{2}", new string('.', outerDots), new string('*', asterisks), new string('.', n));
                outerDots -= 2;
                asterisks += 2;
            }
            else
            {
                if (outerDots <= 0)
                {
                    outerDots += 4;
                    asterisks -= 4;
                }

                Console.WriteLine("{0}{1}{2}", new string('.', outerDots), new string('*', asterisks), new string('.', n));
                outerDots += 2;
                asterisks -= 2;
            }
        }

        outerDots = 1;
        asterisks = (n * 2) - 2;

        for (int i = 1; i <= (n - 1) / 2; i++)
        {
            if (i == 1)
            {
                Console.WriteLine("{0}", new string('*', asterisks + 2));
            }
            else
            {
                Console.WriteLine("{0}{1}{0}", new string('.', outerDots), new string('*', asterisks));
                outerDots++;
                asterisks -= 2;
            }
        }
    }
}
