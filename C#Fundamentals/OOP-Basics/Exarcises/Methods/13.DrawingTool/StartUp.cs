using System;

namespace _13.DrawingTool
{        
    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            if (inputLine.Equals("Rectangle"))
            {
                var width = int.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                var rect = new Rectangle(width, height);
                CorDraw.Drow(rect);
            }
            else
            {
                var a = int.Parse(Console.ReadLine());
                var square = new Square(a);
                CorDraw.Drow(square);
            }
        }
    }
}
