using System;

public class Car : Vehicle
{
    private const double AcConsumptionMod = 0.9;

    public Car(double fuelQuantity, double fuelConsumption, double capacity)
    {
        base.Capacity = capacity;
        base.FuelQuantity = fuelQuantity;
        base.FuelConsumption = fuelConsumption + AcConsumptionMod;

    }

    protected override double FuelQuantity
    {
        set
        {
            if (value > this.Capacity)
            {
                throw new ArgumentException("Cannot fit in tank");
            }

            base.FuelQuantity = value;
        }
    }
}

