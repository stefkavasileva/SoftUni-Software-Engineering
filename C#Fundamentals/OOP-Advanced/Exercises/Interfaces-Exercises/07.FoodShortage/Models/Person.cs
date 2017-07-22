public abstract class Person : IPerson
{
    protected Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        this.Food = 0;
    }

    public string Name { get; }

    public int Age { get; }

    public void BuyFood()
    {
        
    }

    public int Food { get; protected set; }
}

