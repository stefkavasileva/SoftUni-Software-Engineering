using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Devision
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double p1 = 0;
        double p2 = 0;
        double p3 = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                p1++;

            if (num % 3 == 0)
                p2++;

            if (num % 4 == 0)
                p3++;

        }

        Console.WriteLine("{0:f2}%", (p1 / n) * 100.0);
        Console.WriteLine("{0:f2}%", (p2 / n) * 100.0);
        Console.WriteLine("{0:f2}%", (p3 / n) * 100.0);
    }
}

