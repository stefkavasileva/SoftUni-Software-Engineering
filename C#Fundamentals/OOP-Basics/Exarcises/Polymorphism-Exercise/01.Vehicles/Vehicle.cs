using System;

public abstract class Vehicle
{
    protected virtual double FuelQuantity { get; set; }
    protected double FuelConsumption { get; set; }
    protected virtual double Capacity { get; set; }

    public virtual void Reflue(double fuel)
    {
        if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        this.FuelQuantity += fuel;
    }

    protected virtual bool CanDrive(double distance, bool isAcOn)
    {
        var fuelRequired = distance * this.FuelConsumption;
        if (fuelRequired <= this.FuelQuantity)
        {
            this.FuelQuantity -= fuelRequired;
            return true;
        }

        return false;
    }

    public string TryDrive(double distance , bool isAcOn)
    {
        if (this.CanDrive(distance,isAcOn))
        {
            return $"{this.GetType().Name} travelled {distance} km";
        }

        return $"{this.GetType().Name} needs refueling";
    }

    public string TryDrive(double distance)
    {
        return this.TryDrive(distance, true);
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}

