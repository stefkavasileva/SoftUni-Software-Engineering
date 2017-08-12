public class Axe :Weapon
{
    public Axe(string name, State state) 
        : base(name, state)
    {
        
    }

    public override State State
    {
        get => this.State;
        set
        {
            
        }
    }
}
