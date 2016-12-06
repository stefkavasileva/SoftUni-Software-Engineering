using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public static double CalDistance(Point p1, Point p2)
    {
        double sideA = p1.X - p2.X;
        double sideB = p1.Y - p2.Y;
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
            points[p] = Point.ReadPoint();
        }
        return points;
    }

    public static Point[] FindClosestPoints(Point[] points)
    {
        Point[] closestPoints = new Point[2];
        double minDistance = double.MaxValue;

        for (int firstP = 0; firstP < points.Length; firstP++)
        {
            for (int secondP = firstP + 1; secondP < points.Length; secondP++)
            {
                Point p1 = points[firstP];
                Point p2 = points[secondP];
                double distance = Point.CalDistance(p1, p2);
                if (distance < minDistance)
                {
                    closestPoints[0] = p1;
                    closestPoints[1] = p2;
                    minDistance = distance;
                }
            }
        }

        return closestPoints;
    }

    public override string ToString()
    {
        return string.Format("({0}, {1})", this.X, this.Y);
    }

}

class ClosestTwoPoints
{
    static void Main(string[] args)
    {
        Point[] points = Point.ReadsArrayOfPoints();
        Point[] closestPoints = Point.FindClosestPoints(points);
        double minDistance = Point.CalDistance(closestPoints[0], closestPoints[1]);

        Console.WriteLine("{0:f3}", minDistance);
        foreach (var point in closestPoints)
        {
            Console.WriteLine(point);
        }
    }
}

