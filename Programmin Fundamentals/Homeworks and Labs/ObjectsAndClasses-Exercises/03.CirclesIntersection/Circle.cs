namespace _03.CirclesIntersection
{
    public class Circle
    {
        public Circle(Point point, double radius)
        {
            this.Center = point;
            this.Radius = radius;
        }

        public Point Center { get; set; }

        public double Radius { get; set; }
    }
}
