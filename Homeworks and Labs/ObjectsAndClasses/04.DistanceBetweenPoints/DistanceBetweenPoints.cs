using System;
using System.Linq;

public class Point
{
    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public double X { get; set; }

    public double Y { get; set; }
}

public class DistanceBetweenPoints
{
    public static void Main()
    {
        int[] firstPointCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] secondPointCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Point firstPoint = new Point(firstPointCoordinates[0], firstPointCoordinates[1]);
        Point secondPoint = new Point(secondPointCoordinates[0], secondPointCoordinates[1]);

        double distance = CalDistanceBetweenTwoPoints(firstPoint, secondPoint);

        Console.WriteLine($"{distance:f3}");
    }

    public static double CalDistanceBetweenTwoPoints(Point firstPoint, Point secondPoint)
    {
        double sideA = firstPoint.X - secondPoint.X;
        double sideB = firstPoint.Y - secondPoint.Y;

        double distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));

        return distance;
    }
}
