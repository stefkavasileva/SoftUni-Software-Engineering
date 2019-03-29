public class Box
{
    public int Width { get; set; }

    public int Height { get; set; }

    public int Perimeter { get; set; }

    public int Area { get; set; }

    public static int CalculatePerimeter(int width, int height)
    {
        return (2 * width) + (2 * height);
    }

    public static int CalculateArea(int width, int height)
    {
        return width * height;
    }
}