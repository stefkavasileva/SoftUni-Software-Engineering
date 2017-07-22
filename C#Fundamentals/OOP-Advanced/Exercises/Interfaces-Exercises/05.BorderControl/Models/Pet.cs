public class Pet : IName, IBirthdate
{
    public Pet(string name, string birthdate)
    {
        this.Birthdate = birthdate;
        this.Name = name;
    }

    public string Name { get; protected set; }
    public string Birthdate { get; protected set; }
}

