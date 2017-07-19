public class Audi : ICar
{
    public string Model { get; }
    public string Color { get; }

    public string Start()
    {
        throw new System.NotImplementedException();
    }

    public string Stop()
    {
        throw new System.NotImplementedException();
    }

    public override string ToString()
    {
        return base.ToString();
    }

}

