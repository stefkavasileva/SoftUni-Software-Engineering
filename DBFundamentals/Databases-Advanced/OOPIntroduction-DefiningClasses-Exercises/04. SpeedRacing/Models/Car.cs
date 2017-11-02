public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumption;

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.DistanceTraveled = 0;    
    }

    public string Model
    {
        get => this.model;
        set => this.model = value;
    }

    public double FuelAmount
    {
        get => this.fuelAmount;
        set => this.fuelAmount = value;
    }

    public double FuelConsumption
    {
        get => this.fuelConsumption;
        set => this.fuelConsumption = value;
    }

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

