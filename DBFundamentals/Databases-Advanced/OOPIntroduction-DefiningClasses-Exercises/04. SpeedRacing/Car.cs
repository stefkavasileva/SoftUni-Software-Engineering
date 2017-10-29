using System;

public class Car
{
    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.DistanceTraveled = 0;    
    }

    public string Model { get; set; }

    public double FuelAmount { get; set; }

    public double FuelConsumption  { get; set; }

    public double DistanceTraveled { get; set; }

    public static bool CanDrive(Car car, double distance)
    {
        var km = car.FuelAmount / car.FuelConsumption;
        if (km >= distance)
        {
            var liters = distance * car.FuelConsumption;
            car.FuelAmount -= liters;
            car.DistanceTraveled += distance;
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        return $"{this.Model} {this.FuelAmount:F2} {this.DistanceTraveled}";
    }
}

