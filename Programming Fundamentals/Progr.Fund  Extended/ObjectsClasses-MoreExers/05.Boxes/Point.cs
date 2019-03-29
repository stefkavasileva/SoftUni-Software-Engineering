using System;

public class Point
{
    public double X { get; set; }

    public double Y { get; set; }

    public static int CalDistance(Point firstPoint, Point seconPoint)
    {
        double sideA = firstPoint.X - seconPoint.X;
        double sideB = firstPoint.Y - seconPoint.Y;

        int distance = (int)Math.Sqrt((sideA * sideA) + (sideB * sideB));

        return distance;
    }
}