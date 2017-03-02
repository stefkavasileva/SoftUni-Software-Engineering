using System;

public class Stop
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int topSize = n + 2;
        int bottomSize = n;
        int dots = n + 1;
        int dashes = (2 * n) - 3;

        for (int i = 1; i <= topSize; i++)
        {
            if (i == 1)
                Console.WriteLine("{0}{1}{0}",
                    new string('.', n + 1),
                    new string('_', (n * 2) + 1));
            else if (i == topSize)
                Console.WriteLine("//{0}STOP!{0}\\\\",
                    new string('_', (dashes - 4) / 2));
            else
                Console.WriteLine("{0}//{1}\\\\{0}",
                    new string('.', dots),
                    new string('_', dashes));
            dashes += 2;
            dots--;
        }

        dots = 0;
        dashes -= 2;

        for (int i = 1; i <= bottomSize; i++)
        {
            if (i == bottomSize)
                Console.WriteLine("{0}\\\\{1}//{0}",
                       new string('.', dots),
                       new string('_', dashes));
            else
                Console.WriteLine("{0}\\\\{1}//{0}",
                   new string('.', dots),
                   new string('_', dashes));
            dashes -= 2;
            dots++;
        }
    }
}
