using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var counts = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var rectangles = new Rectangle[counts[0]];

        for (int i = 0; i < counts[0]; i++)
        {
            var tokens = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            var id = tokens[0];
            var width = double.Parse(tokens[1]);
            var height = double.Parse(tokens[2]);
            var x = double.Parse(tokens[3]);
            var y = double.Parse(tokens[4]);

            rectangles[i] = new Rectangle(id, width, height, x, y);
        }

        for (int i = 0; i < counts[1]; i++)
        {
            var tokens = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            var firstRectangle = rectangles.Where(r => r.ID == tokens[0]).First();
            var secondRectangle = rectangles.Where(r => r.ID == tokens[1]).First();

            Console.WriteLine(firstRectangle.Intersects(secondRectangle));
        }
    }
}