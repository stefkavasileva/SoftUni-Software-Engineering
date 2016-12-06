using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public static double CalDistance(Point p1, Point p2)
    {
        double distance = 0.0;
        double sideA = p1.X - p2.X;
        double sideB = p1.Y - p2.Y;
        distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));

        return distance;
    }

}

class DistanceBetweenPoints
{
    static void Main(string[] args)
    {
        int[] coordinatesP1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] coordinatesP2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Point p1 = new Point();
        Point p2 = new Point();
        p1.X = coordinatesP1[0];
        p1.Y = coordinatesP1[1];
        p2.X = coordinatesP2[0];
        p2.Y = coordinatesP2[1];
        double distance = CalDistance(p1, p2);
        Console.WriteLine($"{distance:f3}");
    }

    public static double CalDistance(Point p1, Point p2)
    {
        double distance = 0.0;
        double sideA = p1.X - p2.X;
        double sideB = p1.Y - p2.Y;
        distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));

        return distance;
    }
}

