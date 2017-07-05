using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private decimal money;

    public List<Product> Products { get; set; }

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.Products = new List<Product>();
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            this.name = value;
        }
    }

    public decimal Money
    {
        get
        {
            return this.money;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.money = value;
        }
    }

}

