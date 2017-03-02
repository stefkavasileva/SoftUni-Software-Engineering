using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TriangleArea
{
    static void Main(string[] args)
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());

        int h = Math.Abs(y1 - y2);
        int a = Math.Abs(x2 - x3);

        double area = (a * h) / 2.0;

        Console.WriteLine(area);
    }
}

