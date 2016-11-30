using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculateTriangleArea
{
    static void Main(string[] args)
    {
        double side = double.Parse(Console.ReadLine());
        double hight = double.Parse(Console.ReadLine());

        double triangleArea= CalcTrangleArea(side, hight);
        Console.WriteLine(triangleArea);
    }

    private static double CalcTrangleArea(double side, double hight)
    {
        double area = side * hight/2;
        return area;
    }
}

