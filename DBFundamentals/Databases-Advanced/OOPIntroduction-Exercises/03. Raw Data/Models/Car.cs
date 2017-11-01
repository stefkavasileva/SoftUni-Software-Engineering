public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;

    public Car(string model, Engine engine, Cargo cargo)
    {
        this.Model = model;
        this.Engine = engine;
        this.Cargo = cargo;
        this.Tires = new Tire[4];
    }

    public string Model
    {
        get => this.model;
        set => this.model = value;
    }

    public Engine Engine
    {
        get => this.engine;
        set => this.engine = value;
    }

    public Cargo Cargo
    {
        get => this.cargo;
        set => this.cargo = value;
    }

    public Tire[] Tires { get; set; }
}
