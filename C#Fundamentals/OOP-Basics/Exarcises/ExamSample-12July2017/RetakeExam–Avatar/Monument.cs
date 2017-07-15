public abstract class Monument
{
    protected string Name { get; set; }

    protected Monument(string name)
    {
        this.Name = name;
    }

    public abstract int GetPowe();
}
