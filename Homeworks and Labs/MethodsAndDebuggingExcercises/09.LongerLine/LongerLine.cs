using System;

public class LongerLine
{
    public static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        double firstDistance = CalcDistance(x1, y1, x2, y2);
        double secondDistance = CalcDistance(x3, y3, x4, y4);

        PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4, firstDistance, secondDistance);
    }

    private static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, double firstDistance, double secondDistance)
    {
        if (firstDistance >= secondDistance)
        {
            PrintClosestPoint(x1, y1, x2, y2);
            PrinFarawayPoint(x1, y1, x2, y2);
        }
        else
        {
            PrintClosestPoint(x3, y3, x4, y4);
            PrinFarawayPoint(x3, y3, x4, y4);
        }
    }

    private static void PrintClosestPoint(double x1, double y1, double x2, double y2)
    {
        double firstRadius = (x1 * x1) + (y1 * y1);
        double secondRadius = (x2 * x2) + (y2 * y2);

        if (firstRadius <= secondRadius)
        {
            Console.Write($"({x1}, {y1})");
        }
        else
        {
            Console.Write($"({x2}, {y2})");
        }
    }

    private static void PrinFarawayPoint(double x1, double y1, double x2, double y2)
    {
        double firstRadius = (x1 * x1) + (y1 * y1);
        double secondRadius = (x2 * x2) + (y2 * y2);

        if (firstRadius > secondRadius)
        {
            Console.WriteLine($"({x1}, {y1})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})");
        }
    }

    private static double CalcDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        return distance;
    }
}
