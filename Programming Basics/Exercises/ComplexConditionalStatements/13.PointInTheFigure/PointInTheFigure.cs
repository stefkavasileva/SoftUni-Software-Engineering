using System;

public class PointInTheFigure
{
    public static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool outOfRange = (x < 0) || (y < 0) || (y > (4 * h)) || (x > 3 * h);
        bool outOfSides = (y > h) && ((x < h) || (x > 2 * h));

        bool horizontalRectangle = ((y > 0) && (y < h)) && ((x > 0) && (x < 3 * h));
        bool verticalRectangle = ((x > h) && (x < 2 * h)) && ((y > 0) && (y < 4 * h));

        if (outOfRange || outOfSides)
        {
            Console.WriteLine("outside");
        }
        else if (horizontalRectangle || verticalRectangle)
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("border");
        }
    }
}
