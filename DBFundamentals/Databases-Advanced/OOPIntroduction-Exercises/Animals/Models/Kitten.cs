public class Kitten : Cat
{
    public Kitten(string name, int age, string gender)
        : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
        return Constats.KittenSound;
    }
}

