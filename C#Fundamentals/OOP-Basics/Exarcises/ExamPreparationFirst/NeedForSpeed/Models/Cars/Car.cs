using System;
using System.Collections.Generic;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int suspension;
    private int durability;

    protected Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.Horsepower = horsepower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
        this.AddOns = new List<string>();
    }

    public int Stars { get; set; }

    public List<string> AddOns { get; set; }

    public string Brand
    {
        get => this.brand;
        protected set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{nameof(this.brand)} property is required!");
            }

            this.brand = value;
        }
    }

    public string Model
    {
        get => this.model;
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{nameof(this.model)} property is required!");
            }

            this.model = value;
        }
    }

    public int YearOfProduction
    {
        get => this.yearOfProduction;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(this.yearOfProduction)} can not be negative!");
            }

            this.yearOfProduction = value;
        }
    }

    public int Horsepower
    {
        get => this.horsepower;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(this.horsepower)} can not be negative!");
            }

            this.horsepower = value;
        }
    }

    public int Acceleration
    {
        get => this.acceleration;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(this.acceleration)} can not be negative!");
            }

            this.acceleration = value;
        }
    }

    public int Suspension
    {
        get => this.suspension;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(this.suspension)} can not be negative!");
            }

            this.suspension = value;
        }
    }

    public int Durability
    {
        get => this.durability;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(this.durability)} can not be negative!");
            }

            this.durability = value;
        }
    }
}

