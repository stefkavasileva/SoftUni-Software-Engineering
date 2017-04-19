public class Rectangle
{
    public double Left { get; set; }

    public double Top { get; set; }

    public double Width { get; set; }

    public double Hight { get; set; }

    public double Bottom
    {
        get
        {
            return this.Top + this.Hight;
        }
    }

    public double Right
    {
        get
        {
            return this.Left + this.Width;
        }
    }
}

