using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TwoDRectangleArea
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double area = Math.Abs(x1 - x2) * Math.Abs(y1 - y2);
        double perimeter = 2 * (Math.Abs(x1 - x2) + Math.Abs(y1 - y2));

        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}

