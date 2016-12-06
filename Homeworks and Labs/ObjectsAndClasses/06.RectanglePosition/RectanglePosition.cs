using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle
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

    public static bool IsInside(Rectangle rect1, Rectangle rect2)
    {
        bool isInside =
            rect1.Left >= rect2.Left &&
            rect1.Right <= rect2.Right &&
            rect1.Top <= rect2.Top &&
            rect1.Bottom <= rect2.Bottom;
        return isInside;
    }
}


class RectanglePosition
{
    static void Main(string[] args)
    {

        Rectangle rect1 = Rectangle.ReadRectangle();
        Rectangle rect2 = Rectangle.ReadRectangle();
        bool isInside = Rectangle.IsInside(rect1, rect2);

        if (isInside)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not inside");
        }
    }
}

