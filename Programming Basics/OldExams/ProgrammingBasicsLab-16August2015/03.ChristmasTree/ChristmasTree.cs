using System;

public class ChristmasTree
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outer = n;
        int inner = 1;

        for (int i = 1; i <= (n + 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('\'', outer),
                new string('^', inner));
            outer--;
            inner += 2;
        }

        outer = n - 1;
        inner = 3;
        for (int i = 1; i <= (n + 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
               new string('\'', outer),
               new string('^', inner));
            outer--;
            inner += 2;
        }

        outer = n - 1;
        for (int i = 1; i <= (n + 1) / 2; i++)
        {
            Console.WriteLine("{0}| |{0}",
               new string('\'', outer));
        }

        Console.WriteLine("{0}", new string('-', (2 * n) + 1));
    }
}
