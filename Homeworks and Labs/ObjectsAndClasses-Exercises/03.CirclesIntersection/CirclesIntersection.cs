using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Circle
{
    public Point Center { get; set; }

    public double Radius { get; set; }

    public static bool IsIntersect(Circle c1, Circle c2)
    {
        bool isIntersect = false;
        double distance = Point.CalDistance(c1.Center, c2.Center);
        if (distance <= c1.Radius + c2.Radius)
        {
            isIntersect = true;
        }

        return isIntersect;
    }

    public static Circle ReadCircle()
    {
        double[] coordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();
        Point point = new Point { X = coordinates[0], Y = coordinates[1] };
        double radius = coordinates[2];
        Circle c1 = new Circle { Center = point, Radius = radius };
        return c1;
    }


}

class Point
{
    public double X { get; set; }

    public double Y { get; set; }

    public static double CalDistance(Point p1, Point p2)
    {
        double a = p1.X - p2.X;
        double b = p2.Y - p1.Y;

        double distance = Math.Sqrt((a * a) + (b * b));
        return distance;
    }
}

class CirclesIntersection
{
    static void Main(string[] args)
    {
        Circle c1 = Circle.ReadCircle();
        Circle c2 = Circle.ReadCircle();

        bool isIntersect = Circle.IsIntersect(c1, c2);

        if (isIntersect)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}

