using System;

public class Product
{
    private string name;
    private decimal cost;

    public Product(string name, decimal cost)
    {
        this.Name = name;
        this.Cost = cost;
    }

    public string Name
    {
        get=>this.name; 
        private set => this.name = value; 
    }

    public decimal Cost
    {
        get => this.cost; 
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException(ErrorMessages.InvalidMoneyValue);
            }

            this.cost = value;
        }
    }

    public override string ToString()
    {
        return this.name;
    }
}