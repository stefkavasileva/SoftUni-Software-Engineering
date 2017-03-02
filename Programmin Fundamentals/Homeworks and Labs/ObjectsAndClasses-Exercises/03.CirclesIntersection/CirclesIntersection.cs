namespace _03CirclesIntersection
{
    using System;
    using System.Linq;
    using _03.CirclesIntersection;

    public class CirclesIntersection
    {
        public static void Main()
        {
            var firstCircleProp = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var secondCircleProp = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var firstPoint = new Point(firstCircleProp[0], firstCircleProp[1]);
            var secondPoint = new Point(secondCircleProp[0], secondCircleProp[1]);

            var firstCircle = new Circle(firstPoint, firstCircleProp[2]);
            var secondCircle = new Circle(secondPoint, secondCircleProp[2]);

            bool isIntersect = IsIntersect(firstCircle, secondCircle);

            if (isIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool IsIntersect(Circle firstCircle, Circle secondCircle)
        {
            double distance = CalcDistrance(firstCircle.Center, secondCircle.Center);

            bool isIntersect = false;

            if (distance <= firstCircle.Radius + secondCircle.Radius)
            {
                isIntersect = true;
            }

            return isIntersect;
        }

        public static double CalcDistrance(Point firstPoint, Point secondPoint)
        {
            var diffX = secondPoint.X - firstPoint.X;
            var diffY = secondPoint.Y - firstPoint.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            var distance = Math.Sqrt(powX + powY);

            return distance;
        }
    }
}