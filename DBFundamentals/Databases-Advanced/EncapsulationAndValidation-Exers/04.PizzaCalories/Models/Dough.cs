using System;
using System.Collections.Generic;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double weightGrams;

    private static readonly IDictionary<string, double> DoughsWithModifiers = new Dictionary<string, double>
    {
        { "white", 1.5 },
        { "wholegrain", 1.0 },
        { "crispy", 0.9 },
        { "chewy", 1.1 },
        { "homemade", 1.0 }
    };

    public Dough(string flourType, string bakingTechnique, double weightGrams)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.WeightGrams = weightGrams;
    }

    private string FlourType
    {
        set
        {
            if (!IsDoughValid(value))
            {
                throw new ArgumentException(ErrorMessages.InvalidDough);
            }

            this.flourType = value;
        }
    }

    private string BakingTechnique
    {
        set
        {
            if (!IsDoughValid(value))
            {
                throw new ArgumentException(ErrorMessages.InvalidDough);
            }

            this.bakingTechnique = value;
        }
    }

    private double WeightGrams
    {
        get
        {
            return this.weightGrams;
        }

        set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException(ErrorMessages.InvalidDoughRange);
            }

            this.weightGrams = value;
        }
    }

    public double CalcCalories()
    {
        double result = this.WeightGrams * 2 * GetDoughModifier(this.flourType) * GetDoughModifier(this.bakingTechnique);
        return result;
    }

    public static bool IsDoughValid(string doughType)
    {
        string searcherDoughType = doughType.ToLower();

        if (DoughsWithModifiers.ContainsKey(searcherDoughType))
        {
            return true;
        }

        return false;
    }


    public static double GetDoughModifier(string flourTypeOrBakingTechnique)
    {
        string searcherDoughModifier = flourTypeOrBakingTechnique.ToLower();

        if (DoughsWithModifiers.ContainsKey(searcherDoughModifier))
        {
            double doughModifier = DoughsWithModifiers[searcherDoughModifier];
            return doughModifier;
        }

        throw new ArgumentException(ErrorMessages.InvalidModifier);
    }
}

