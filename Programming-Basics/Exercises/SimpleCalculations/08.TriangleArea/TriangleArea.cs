using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TriangleArea
{
    static void Main(string[] args)
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = side * height / 2;

        Console.WriteLine("Triangle area {0}", Math.Round(area, 2));
    }
}

