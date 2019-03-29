using System;
using System.Collections.Generic;
using System.Linq;

public class Boxes
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var boxes = new List<Box>();

        while (!inputLine.Equals("end"))
        {
            var tokens = inputLine
                .Split(" | :".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var upperLeft = new Point { X = tokens[0], Y = tokens[1] };
            var upperRight = new Point { X = tokens[2], Y = tokens[3] };
            var bottomLeft = new Point { X = tokens[4], Y = tokens[5] };
            var bottomRight = new Point { X = tokens[6], Y = tokens[7] };

            var width = Point.CalDistance(upperLeft, upperRight);
            var hight = Point.CalDistance(upperLeft, bottomLeft);
            var perimeter = Box.CalculatePerimeter(width, hight);
            var area = Box.CalculateArea(width, hight);

            var box = new Box { Height = hight, Width = width, Area = area, Perimeter = perimeter };
            boxes.Add(box);

            inputLine = Console.ReadLine();
        }

        foreach (var box in boxes)
        {
            Console.WriteLine($"Box: {box.Width}, {box.Height}");
            Console.WriteLine($"Perimeter: {box.Perimeter}");
            Console.WriteLine($" Area: {box.Area}");
        }
    }
}

