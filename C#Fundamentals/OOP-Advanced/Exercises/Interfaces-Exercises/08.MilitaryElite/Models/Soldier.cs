public abstract class Soldier :ISoldier
{
    protected Soldier(string id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string Id { get; protected set; }

    public string FirstName { get; protected set; }

    public string LastName { get; protected set; }
}
