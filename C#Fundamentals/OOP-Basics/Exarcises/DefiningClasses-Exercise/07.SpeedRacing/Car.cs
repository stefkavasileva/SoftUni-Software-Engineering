public class Car
{
    private string model;
    private decimal fuel;
    private decimal fuelCost;
    private decimal taveledDistance;

    public string Model { get; set; }
    public decimal Fuel { get; set; }
    public decimal FuelCost { get; set; }
    public decimal TraveledDistance { get; set; }

    public Car(string model, decimal fuel, decimal fuelCost)
    {
        this.Model = model;
        this.Fuel = fuel;
        this.FuelCost = fuelCost;
        this.TraveledDistance = 0;
    }

    public static bool CanDrive(Car car, decimal distance)
    {
        var km = car.Fuel / car.FuelCost;
        if (km >= distance)
        {
            var liters = distance * car.FuelCost;
            car.Fuel -= liters;
            car.TraveledDistance += distance;
            return true;
        }

        return false;
    }
}