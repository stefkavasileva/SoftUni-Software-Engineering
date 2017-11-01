using System;
using System.Text;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double Length
    {
        get
        {
            return this.length;
        }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException(ErrorMessages.InvalidLength);
            }

            this.length = value;
        }
    }

    public double Width
    {
        get
        {
            return this.width;
        }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException(ErrorMessages.InvalidWidth);
            }

            this.width = value;
        }
    }

    public double Height
    {
        get
        {
            return this.height;
        }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException(ErrorMessages.InvalidHeight);
            }

            this.height = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Surface Area - {((2 * this.length * this.Width) + (2 * this.length * this.Height) + (2 * Width * Height)):f2}");
        sb.AppendLine($"Lateral Surface Area - {((2 * this.length * this.Height) + (2 * this.Width * this.Height)):f2}");
        sb.Append($"Volume - {(this.length * this.Height * this.Width):f2}");

        return sb.ToString();
    }
}