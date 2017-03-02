using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Histogram
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        double p4 = 0;
        double p5 = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num >= 800)
                p5++;
            else if (num >= 600 && num <= 799)
                p4++;
            else if (num >= 400 && num <= 599)
                p3++;
            else if (num >= 200 && num <= 399)
                p2++;
            else
                p1++;
        }

        Console.WriteLine("{0:f2}%", (p1 / n) * 100);
        Console.WriteLine("{0:f2}%", (p2 / n) * 100);
        Console.WriteLine("{0:f2}%", (p3 / n) * 100);
        Console.WriteLine("{0:f2}%", (p4 / n) * 100);
        Console.WriteLine("{0:f2}%", (p5 / n) * 100);
    }
}

