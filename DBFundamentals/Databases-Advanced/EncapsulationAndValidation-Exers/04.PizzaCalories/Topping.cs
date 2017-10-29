using System;
using System.Linq;

public class Topping
{
    private readonly string[] ToppingTypes = { "meat", "veggies", "cheese", "sauce" };
    private const int MinWeight = 1;
    private const int MaxWeight = 50;
    private const decimal MeatValue = 1.2m;
    private const decimal VeggiesValue = 0.8m;
    private const decimal CheeseValue = 1.1m;
    private const decimal SauceValue = 0.9m;

    private string type;
    private double weight;

    public Topping(string type, double weight)
    {
        this.Type = type;
        this.Weight = weight;
    }

    public string Type
    {
        get => this.type;
        private set
        {
            if (!ToppingTypes.Contains(value.ToLower()) || string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            this.type = value;
        }
    }

    public double Weight
    {
        get => this.weight;
        private set
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException($"{this.type} weight should be in the range [{MinWeight}..{MaxWeight}].");
            }

            this.weight = value;
        }
    }

    public decimal CalcCalories()
    {
        var typeValue = 0.0m;
        switch (this.type.ToLower())
        {
            case "meat":
                typeValue = MeatValue;
                break;
            case "veggies":
                typeValue = VeggiesValue;
                break;
            case "cheese":
                typeValue = CheeseValue;
                break;
            case "sauce":
                typeValue = SauceValue;
                break;
        }

        return 2 * typeValue * (decimal)this.Weight;
    }
}
