using System;
using System.Linq;

public class Point
{
    public double X { get; set; }

    public double Y { get; set; }

    public override string ToString()
    {
        return string.Format("({0}, {1})", this.X, this.Y);
    }
}

public class ClosestTwoPoints
{
    public static void Main()
    {
        Point[] points = ReadsArrayOfPoints();
        Point[] closestPoints = FindClosestPoints(points);

        double minDistance = CalDistance(closestPoints[0], closestPoints[1]);

        Console.WriteLine($"{minDistance:f3}");

        foreach (var point in closestPoints)
        {
            Console.WriteLine(point);
        }
    }

    public static double CalDistance(Point firstPoint, Point seconPoint)
    {
        double sideA = firstPoint.X - seconPoint.X;
        double sideB = firstPoint.Y - seconPoint.Y;

        double distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));

        return distance;
    }

    public static Point ReadPoint()
    {
        double[] coordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();

        Point point = new Point { X = coordinates[0], Y = coordinates[1] };

        return point;
    }

    public static Point[] ReadsArrayOfPoints()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        Point[] points = new Point[sizeOfArray];

        for (int p = 0; p < sizeOfArray; p++)
        {
            points[p] = ReadPoint();
        }

        return points;
    }

    public static Point[] FindClosestPoints(Point[] points)
    {
        Point[] closestPoints = new Point[2];

        double minDistance = double.MaxValue;

        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                Point firstPoint = points[i];
                Point secondPoint = points[j];

                double distance = CalDistance(firstPoint, secondPoint);

                if (distance < minDistance)
                {
                    closestPoints[0] = firstPoint;
                    closestPoints[1] = secondPoint;
                    minDistance = distance;
                }
            }
        }

        return closestPoints;
    }
}
