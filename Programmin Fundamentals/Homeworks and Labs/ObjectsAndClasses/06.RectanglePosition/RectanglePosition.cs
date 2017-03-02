using System;
using System.Linq;

public class Rectangle
{
    public double Left { get; set; }

    public double Top { get; set; }

    public double Width { get; set; }

    public double Hight { get; set; }

    public double Bottom
    {
        get
        {
            return this.Top + this.Hight;
        }
    }

    public double Right
    {
        get
        {
            return this.Left + this.Width;
        }
    }
}

public class RectanglePosition
{
    public static void Main()
    {
        Rectangle firstRectangle = ReadRectangle();
        Rectangle secondRectangle = ReadRectangle();

        bool isInside = IsInside(firstRectangle, secondRectangle);

        if (isInside)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not inside");
        }
    }

    public static Rectangle ReadRectangle()
    {
        double[] coordinats = Console.ReadLine().Split().Select(double.Parse).ToArray();

        Rectangle rect = new Rectangle
        {
            Left = coordinats[0],
            Top = coordinats[1],
            Width = coordinats[2],
            Hight = coordinats[3]
        };

        return rect;
    }

    public static bool IsInside(Rectangle firstRectangle, Rectangle secondRectangle)
    {
        bool isInside =
            firstRectangle.Left >= secondRectangle.Left &&
            firstRectangle.Right <= secondRectangle.Right &&
            firstRectangle.Top <= secondRectangle.Top &&
            firstRectangle.Bottom <= secondRectangle.Bottom;

        return isInside;
    }
}
