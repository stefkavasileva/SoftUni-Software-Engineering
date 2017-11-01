using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private readonly IList<Topping> toppings;
    private readonly Dough dough;
    private string name;

    public Pizza(string name, Dough dough)
    {
        this.Name = name;
        this.dough = dough;
        this.toppings = new List<Topping>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (string.IsNullOrEmpty(value) || value.Length > 15)
            {
                throw new ArgumentException(ErrorMessages.InvalidPizzaName);
            }

            this.name = value;
        }
    }

    public void AddTopping(Topping topping)
    {
        this.toppings.Add(topping);

        if (this.toppings.Count > 10)
        {
            throw new ArgumentException(ErrorMessages.InvalidNumberOdToppings);
        }
    }

    public double CalcTotalCalories()
    {
        double doughCalories = this.dough.CalcCalories();
        double toppingsCalories = (double)this.toppings.Sum(t => t.CalcCalories());

        return doughCalories + toppingsCalories;
    }
}
