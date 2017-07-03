using System;
using System.Linq;

public class Dough
{
    private readonly string[] DoughTypes = { "white", "wholegrain" };
    private readonly string[] BakingTechTypes = { "crispy", "chewy", "homemade" };
    private const int MinWeight = 1;
    private const int MaxWeight = 200;
    private const decimal WhiteValue = 1.5m;
    private const decimal WholegrainValue = 1m;
    private const decimal CrispyValue = 0.9m;
    private const decimal ChewyValue = 1.1m;
    private const decimal HomemadeValue = 1m;

    private string doughType;
    private string bakingTech;
    private double weight;

    public Dough(string doughType, string bakingTech, double weight)
    {
        this.DoughType = doughType;
        this.BakingTech = bakingTech;
        this.Weight = weight;
    }

    public Dough()
    {

    }

    public string DoughType
    {
        get => this.doughType;
        private set
        {
            if (!DoughTypes.Contains(value.ToLower()) || string.IsNullOrEmpty(value) || value.Equals(" "))
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.doughType = value;
        }
    }
    public string BakingTech
    {
        get => this.bakingTech;
        private set
        {
            if (!BakingTechTypes.Contains(value.ToLower()) || string.IsNullOrEmpty(value) || value.Equals(" "))
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.bakingTech = value;
        }
    }

    public double Weight
    {
        get => this.weight;
        private set
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
            }

            this.weight = value;
        }
    }

    public decimal CalcCalories()
    {
        var bakingTechValue = 0.0m;
        var typeValue = 0.0m;

        switch (this.doughType.ToLower())
        {
            case "white":
                typeValue = WhiteValue;
                break;
            case "wholegrain":
                typeValue = WholegrainValue;
                break;
            default:
                throw new ArgumentException("Invalid type of dough.");
        }

        switch (this.bakingTech.ToLower())
        {
            case "crispy":
                bakingTechValue = CrispyValue;
                break;
            case "chewy":
                bakingTechValue = ChewyValue;
                break;
            case "homemade":
                bakingTechValue = HomemadeValue;
                break;
            default:
                throw new ArgumentException("Invalid type of dough.");
        }

        return (2 * (decimal)this.Weight) * typeValue * bakingTechValue;
    }
}

