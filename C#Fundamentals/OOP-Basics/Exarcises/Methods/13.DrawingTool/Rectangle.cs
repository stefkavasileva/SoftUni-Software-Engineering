using System;

namespace _13.DrawingTool
{
    public class Rectangle
    {
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Hight = height;
        }

        public int Width { get; set; }
        public int Hight { get; set; }

        public static void Drow(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                var line = i == 0 || i == height - 1 ?
                    $"|{new string('-', width)}|" :
                    $"|{new string(' ', width)}|";

                Console.WriteLine(line);
            }
        }
    }
}
