using System.Text;

public class ShowCar : Car
{
    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) 
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        base.Stars = 0;
    }

    public override string ToString()
    {
       var sb = new StringBuilder();
        sb.AppendLine($"{base.Brand} {base.Model} {base.YearOfProduction}");
        sb.AppendLine($"{base.Horsepower} HP, 100 m/h in {base.Acceleration} s");
        sb.AppendLine($"{base.Suspension} Suspension force, {base.Durability} Durability");
        sb.AppendLine($"{base.Stars} *");
        return sb.ToString().Trim();
    }
}

