using System;
using System.Collections.Generic;

public class Topping
{
    private string type;
    private double weight;

    private static readonly IDictionary<string, double> ToppingsWithModifiers = new Dictionary<string, double>
    {
        { "meat", 1.2 },
        { "veggies", 0.8 },
        { "cheese", 1.1 },
        { "sauce", 0.9 }
    };

    public Topping(string type, double weight)
    {
        this.Type = type;
        this.Weight = weight;
    }

    private string Type
    {
        get
        {
            return this.type;
        }

        set
        {
            if (!IsToppingValid(value))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            this.type = value;
        }
    }

    private double Weight
    {
        get
        {
            return this.weight;
        }

        set
        {
            if (value < 1|| value > 50)
            {
                throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
            }

            this.weight = value;
        }
    }

    public double CalcCalories()
    {
        double result = this.Weight * 2 * GetToppingModifier(this.Type);
        return result;
    }

    public static bool IsToppingValid(string toppingType)
    {
        string searchedTopping = toppingType.ToLower();

        if (ToppingsWithModifiers.ContainsKey(searchedTopping))
        {
            return true;
        }

        return false;
    }

    public static double GetToppingModifier(string toppingName)
    {
        string searchedToppingModifier = toppingName.ToLower();

        if (ToppingsWithModifiers.ContainsKey(searchedToppingModifier))
        {
            double toppingModifier = ToppingsWithModifiers[searchedToppingModifier];
            return toppingModifier;
        }

        throw new ArgumentException("Such a modifier does not exist.");
    }
}
