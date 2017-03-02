using System;

public class RectangleProperties
{
    public static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double hight = double.Parse(Console.ReadLine());

        /////rectangle properies
        double perimeter = 2 * (width + hight);
        double area = width * hight;
        double diagonal = Math.Sqrt((width * width) + (hight * hight));

        Console.WriteLine(perimeter);
        Console.WriteLine(area);
        Console.WriteLine(diagonal);
    }
}
