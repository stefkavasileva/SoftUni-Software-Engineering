using System.Text;

public class Cat
{
    public Cat(string breed, string name)
    {
        this.Breed = breed;
        this.Name = name;
        this.Decibels = null;
        this.EarSize = null;
        this.FurLength = null;
    }

    public string Name { get; set; }
    public string Breed { get; set; }
    public double? EarSize { get; set; }
    public double? FurLength { get; set; }
    public double? Decibels { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"{this.Breed} {this.Name} ");

        if (!this.EarSize.Equals(null))
        {
            sb.Append((int)this.EarSize);
        }
        else if (!this.FurLength.Equals(null))
        {
            sb.Append($"{this.FurLength:f2}");
        }
        else
        {
            sb.Append((int)this.Decibels);
        }

        return sb.ToString();
    }
}