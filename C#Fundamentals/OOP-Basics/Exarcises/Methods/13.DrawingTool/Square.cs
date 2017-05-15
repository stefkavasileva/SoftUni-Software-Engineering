using System;

namespace _13.DrawingTool
{
    public class Square
    {
        public Square(int a)
        {
            this.A = a;
        }

        public int A { get; set; }

        public static void Drow(int a)
        {
            for (int i = 0; i < a; i++)
            {
                var line = i == 0 || i == a - 1 ?
                       $"|{new string('-', a)}|" :
                       $"|{new string(' ', a)}|";

                Console.WriteLine(line);
            }
        }
    }
}
