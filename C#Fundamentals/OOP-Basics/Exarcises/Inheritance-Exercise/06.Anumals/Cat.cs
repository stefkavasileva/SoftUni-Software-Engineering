public class Cat : Animal
{
    public Cat(string name, int age, string gender)
        : base(name, age, gender)
    {

    }

    public override string ProduceSound()
    {
        return "MiauMiau";
    }

}
