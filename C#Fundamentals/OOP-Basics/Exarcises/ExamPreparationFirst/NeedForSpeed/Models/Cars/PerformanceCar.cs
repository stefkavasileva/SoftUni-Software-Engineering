using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PerformanceCar : Car
{
    private const int IncreasesHorsepoweroValue = 50;
    private const int DecreasesSuspensionValue = 25;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction,(horsepower + (horsepower * IncreasesHorsepoweroValue) / 100), acceleration, (suspension - (suspension * DecreasesSuspensionValue) / 100), durability)
    {
        base.AddOns = new List<string>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{base.Brand} {base.Model} {base.YearOfProduction}");
        sb.AppendLine($"{base.Horsepower} HP, 100 m/h in {base.Acceleration} s");
        sb.AppendLine($"{base.Suspension} Suspension force, {base.Durability} Durability");
        var addOns = this.AddOns.Any() ? string.Join(", ", this.AddOns) : "None";

        sb.AppendLine($"Add-ons: {addOns}");
        return sb.ToString().Trim();
    }
}

