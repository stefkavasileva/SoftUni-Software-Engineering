public class Citizen : Person, ICitizen
{
    public Citizen(string name, int age, string group)
        : base(name, age)
    {
        this.Group = group;
    }

    public string Group { get; protected set; }

    public void BuyFood()
    {
        this.Food += 5;
    }
}

