public class Ferrari : ICar
{
    private string model;
    private string brakes;
    private string gasPedal;

    public Ferrari(string driversName)
    {
        this.DriversName = driversName;
        this.Model = model;
        this.GasPedal = gasPedal;
        this.Brakes = brakes;
    }

    public string DriversName { get; }

    public string Model
    {
        get => model;
        private set => this.model = "488-Spider";
    }

    public string Brakes
    {
        get => brakes;
        private set => this.brakes = "Brakes!";
    }

    public string GasPedal
    {
        get => this.gasPedal;
        private set => this.gasPedal = "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Brakes}/{this.GasPedal}/{this.DriversName}";
    }
}
