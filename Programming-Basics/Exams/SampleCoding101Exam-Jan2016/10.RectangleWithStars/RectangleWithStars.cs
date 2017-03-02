using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RectangleWithStars
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int len = n;
        int middle = (n + 1) / 2;

        if (n % 2 == 0)
        {
            len = n - 1;
            middle = n / 2;
        }

        Console.WriteLine(new string('%', 2 * n));

        for (int i = 1; i <= len; i++)
        {
            if (i == middle)
            {
                Console.WriteLine("%{0}**{0}%", new string(' ', ((2 * n) - 4) / 2));
            }
            else
            {
                Console.WriteLine("%{0}%", new string(' ', (2 * n) - 2));

            }
        }

        Console.WriteLine(new string('%', 2 * n));
    }
}

