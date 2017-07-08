using System;

public class Bus : Vehicle
{
    private const double AcConsumptionMod = 1.4;

    public Bus(double fuelQuantity, double fuelConsumption, double capacity)
    {
        base.Capacity = capacity;
        base.FuelQuantity = fuelQuantity;
        base.FuelConsumption = fuelConsumption;
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

    protected override bool CanDrive(double distance, bool isAcOn)
    {
        var requiredFuel = 0.0;

        if (isAcOn)
        {
            requiredFuel = distance * (this.FuelConsumption + AcConsumptionMod);

        }
        else
        {
            requiredFuel = distance * this.FuelConsumption;
        }

        if (requiredFuel <= FuelQuantity)
        {
            this.FuelQuantity -= requiredFuel;
            return true;
        }

        return false;
    }
}