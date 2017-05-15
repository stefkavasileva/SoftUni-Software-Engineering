using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.RectangleIntersection
{  
    public class StartUp
    {
        public static void Main()
        {
            var tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rectanglesCount = tokens[0];
            var checksCount = tokens[1];

            var rectangles = new List<Rectangle>();

            for (int i = 0; i < rectanglesCount; i++)
            {
                var recInfo = Console.ReadLine().Split();
                var id = recInfo[0];
                var width = double.Parse(recInfo[1]);
                var height = double.Parse(recInfo[2]);
                var x = double.Parse(recInfo[3]);
                var y = double.Parse(recInfo[4]);

                var rect = new Rectangle(id, width, height, x, y);
                rectangles.Add(rect);
            }

            for (int i = 0; i < checksCount; i++)
            {
                var idsOfrectanglesToCheck = Console.ReadLine().Split();
                var firstRectangle = rectangles.FirstOrDefault(r => r.Id == idsOfrectanglesToCheck[0]);
                var secondRectangle = rectangles.FirstOrDefault(r => r.Id == idsOfrectanglesToCheck[1]);

                var isIntersect = firstRectangle.IntersectsWith(secondRectangle);
                Console.WriteLine(isIntersect.ToString().ToLower());
            }
        }
    }
}
