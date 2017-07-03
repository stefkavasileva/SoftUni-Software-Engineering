using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private string name;
    private decimal calories;
    private int toppingCount;

    public Pizza(string name, int toppimgCount)
    {
        this.Name = name;
        this.ToppingCount = toppimgCount;
        this.Toppings= new List<Topping>();
    }

    public Pizza()
    {
        
    }

    public string Name { get; private set; }

    public double Calories { get; set; }

    public int ToppingCount
    {
        get => this.toppingCount;
        private set
        {
            if (value < 0 || value > 10)
            {
                throw  new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppingCount = value;
        }
    }

    public Dough Dough { get; set; }
    public List<Topping> Toppings { get; set; }

    public decimal CalcCalories()
    {
        return this.Dough.CalcCalories() + this.Toppings.Sum(t => t.CalcCalories());
    }
}

