using System.Data;

public class Weapon
{
    private string name;

    public Weapon(string name, State state)
    {
        this.name = name;
        this.State = state;
    }

    public virtual State State { get; set; }
}

