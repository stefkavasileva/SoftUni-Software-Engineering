using System;

public class Sunglasses
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == n)
            {
                Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
            }
            else if (i == (n + 1) / 2)
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2), new string('|', n));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2), new string(' ', n));
            }
        }
    }
}
