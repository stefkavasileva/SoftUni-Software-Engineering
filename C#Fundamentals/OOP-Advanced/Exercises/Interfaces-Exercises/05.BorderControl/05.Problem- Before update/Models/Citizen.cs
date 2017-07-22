public class Citizen :ICitizen
{
    public Citizen(string model, string id)
    {
       this.Id = id;
       this.Model = model;
    }

    public string Id { get; protected set; }
    public string Model { get; protected set; }
}

