using System;

public class CalculateTriangleArea
{
    public static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        double hight = double.Parse(Console.ReadLine());

        double triangleArea = CalcTrangleArea(side, hight);
        Console.WriteLine(triangleArea);
    }

    private static double CalcTrangleArea(double side, double hight)
    {
        double area = side * hight / 2;
        return area;
    }
}