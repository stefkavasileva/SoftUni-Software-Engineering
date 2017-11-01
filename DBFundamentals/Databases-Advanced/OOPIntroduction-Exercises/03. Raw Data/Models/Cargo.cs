public class Cargo
{
    private string type;
    private int weight;

    public Cargo(string type, int weight)
    {
        this.Type = type;
        this.Weight = weight;
    }

    public string Type
    {
        get => this.type;
        set => this.type = value;
    }

    public int Weight
    {
        get => this.weight;
        set => this.weight = value;
    }
}