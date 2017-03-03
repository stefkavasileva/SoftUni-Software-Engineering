using System;

public class AceOfDiamonds
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dashes = (n - 3) / 2;
        int symbol = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == n)
            {
                Console.WriteLine("{0}", new string('*', n));
            }
            else if (i > 1 && i <= (n + 1) / 2)
            {
                Console.WriteLine("*{0}{1}{0}*",
                    new string('-', dashes),
                    new string('@', symbol));
                dashes--;
                symbol += 2;
            }
            else
            {
                if (dashes == -1)
                {
                    symbol -= 4;
                    dashes = 1;
                }

                Console.WriteLine("*{0}{1}{0}*",
                    new string('-', dashes),
                    new string('@', symbol));
                dashes++;
                symbol -= 2;
            }
        }
    }
}
