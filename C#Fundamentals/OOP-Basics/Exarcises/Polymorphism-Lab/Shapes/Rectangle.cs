public class Rectangle : Shape
{

    public double Height { get; set; }

    public double Width { get; set; }

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * this.Width + 2 * this.Height;
    }

    public override double CalculateArea()
    {
        return this.Width * this.Height;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}

