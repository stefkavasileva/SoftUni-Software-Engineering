public abstract class Worker
{
    private string id;

    protected Worker(string id)
    {
        this.Id = id;
    }

    protected string Id
    {
        get => this.id;
        set => this.id = value;
    }
}

