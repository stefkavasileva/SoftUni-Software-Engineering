using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Headphones
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n + 1; i++)
        {
            if (i == 1)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), new string('*', n + 2));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}", new string('-', (n - 1) / 2), new string('-', n));
            }
        }
        int outerDashes = ((n - 1) / 2) - 1;
        int innerDashes = n - 2;
        int asterisks = 3;
        for (int i = 1; i <= n - 1; i++)
        {
            if (i >= 1 && i <= (n - 1) / 2)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('-', outerDashes),
                    new string('*', asterisks),
                    new string('-', innerDashes));
                outerDashes--;
                innerDashes -= 2;
                asterisks += 2;
            }
            else
            {
                if (outerDashes == -1)
                {
                    outerDashes = 1;
                    innerDashes = 3;
                    asterisks -= 4;
                }
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('-', outerDashes),
                    new string('*', asterisks),
                    new string('-', innerDashes));
                outerDashes++;
                innerDashes += 2;
                asterisks -= 2;
            }
        }
    }
}
