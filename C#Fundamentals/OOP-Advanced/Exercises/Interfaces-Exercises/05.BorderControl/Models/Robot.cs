public class Robot : IIdentible
{
    public Robot(string model, string id)
    {
        this.Model = model;
        this.Id = id;
    }

    public string Model { get; protected set; }
    public string Id { get; protected set; }
}

