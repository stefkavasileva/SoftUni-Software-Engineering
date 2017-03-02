using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class InsideTheBuilding
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        int x4 = int.Parse(Console.ReadLine());
        int y4 = int.Parse(Console.ReadLine());
        int x5 = int.Parse(Console.ReadLine());
        int y5 = int.Parse(Console.ReadLine());

        Point p1 = new Point { X = x1, Y = y1 };
        Point p2 = new Point { X = x2, Y = y2 };
        Point p3 = new Point { X = x3, Y = y3 };
        Point p4 = new Point { X = x4, Y = y4 };
        Point p5 = new Point { X = x5, Y = y5 };

        Point[] points = new Point[5];
        points[0] = p1;
        points[1] = p2;
        points[2] = p3;
        points[3] = p4;
        points[4] = p5;



        for (int i = 0; i < points.Length; i++)
        {
            bool isInside = PointChecker(points[i], size);
            if (isInside)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }

    private static bool PointChecker(Point point, int size)
    {
        bool isInRectangleOne = point.X >= 0 && point.X <= 3 * size && point.Y >= 0 && point.Y <= size;
        bool isInRectangleTwo = point.X >= size && point.X <= 2 * size && point.Y >= 0 && point.Y <= 4 * size;
        bool isInside = false;

        if (isInRectangleOne || isInRectangleTwo)
        {
            isInside = true;
        }

        return isInside;
    }
}

