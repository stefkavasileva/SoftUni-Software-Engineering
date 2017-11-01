using System.Text;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.Lenght = length;
        this.Width = width;
        this.Height = height;
    }

    public double Lenght
    {
        get => this.length;
        protected set => this.length = value;
    }

    public double Width
    {
        get => this.width;
        protected set => this.width = value;
    }

    public double Height
    {
        get => this.height;
        protected set => this.height = value;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Surface Area - {((2 * this.Lenght * this.Width) + (2 * this.Lenght * this.Height) + (2 * Width * Height)):f2}");
        sb.AppendLine($"Lateral Surface Area - {((2 * this.Lenght * this.Height) + (2 * this.Width * this.Height)):f2}");
        sb.Append($"Volume - {(this.Lenght * this.Height * this.Width):f2}");

        return sb.ToString();
    }
}