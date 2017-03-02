using System;

public class PointOnRectangleBorder
{
    public static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool top = (y == y1) && (x >= x1 && x <= x2);
        bool bottom = (y == y2) && (x >= x1 && x <= x2);
        bool leftSide = (x == x1) && (y >= y1 && y <= y2);
        bool rightSide = (x == x2) && (y >= y1 && y <= y2);

        if (top || bottom || leftSide || rightSide)
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside / Outside");
        }
    }
}