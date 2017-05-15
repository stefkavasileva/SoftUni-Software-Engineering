namespace _13.DrawingTool
{
    public class CorDraw
    {
        public static void Drow(Square square)
        {
            Square.Drow(square.A);
        }

        public static void Drow(Rectangle rectangle)
        {
            Rectangle.Drow(rectangle.Width, rectangle.Hight);
        }
    }
}
