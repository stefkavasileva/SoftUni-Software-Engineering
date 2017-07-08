public class Truck : Vehicle
{
    private const double AcConsumptionMod = 1.6;
    private const double FuelLossFactor = 0.95;

    public Truck(double fuelQuantity, double fuelConsumption,double capacity)
    {
        base.FuelQuantity = fuelQuantity;
        base.FuelConsumption = fuelConsumption + AcConsumptionMod;
        base.Capacity = capacity;
    }

    public override void Reflue(double fuel)
    {
        base.Reflue(fuel * FuelLossFactor);
    }
}

