using System;

public class GeometryCalculator
{
    public static void Main()
    {
        string figureType = Console.ReadLine().ToLower();

        double area = 0.0;

        if (figureType.Equals("triangle"))
        {
            double side = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            area = GetTriangleArea(side, hight);
        }
        else if (figureType.Equals("square"))
        {
            double side = double.Parse(Console.ReadLine());
            area = GetSqareArea(side);
        }
        else if (figureType.Equals("rectangle"))
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            area = GetRectangleArea(width, hight);
        }
        else if (figureType.Equals("circle"))
        {
            double radius = double.Parse(Console.ReadLine());
            area = GetCircleArea(radius);
        }

        PrintArea(area);
    }

    private static double GetCircleArea(double radius)
    {
        double area = Math.PI * radius * radius;
        return area;
    }

    private static double GetRectangleArea(double width, double hight)
    {
        double area = width * hight;
        return area;
    }

    private static double GetSqareArea(double side)
    {
        double area = side * side;
        return area;
    }

    private static void PrintArea(double area)
    {
        Console.WriteLine($"{area:f2}");
    }

    private static double GetTriangleArea(double side, double hight)
    {
        double area = side * hight / 2;
        return area;
    }
}
