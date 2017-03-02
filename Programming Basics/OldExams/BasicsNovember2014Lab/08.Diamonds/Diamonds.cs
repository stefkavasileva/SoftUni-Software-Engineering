using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Diamonds
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int outerDashes = ((n - 1) / 2) - 1;
        int innerDashes = 1;
        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == n)
            {
                Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
            }
            else if (i > 1 && i <= (n + 1) / 2)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('-', outerDashes), new string('-', innerDashes));
                outerDashes--;
                innerDashes += 2;
            }
            else
            {
                if (outerDashes == -1)
                {
                    outerDashes = 1;
                    innerDashes = n - 4;
                }
                Console.WriteLine("{0}*{1}*{0}", new string('-', outerDashes), new string('-', innerDashes));
                outerDashes++;
                innerDashes -= 2;
            }
        }
    }
}

