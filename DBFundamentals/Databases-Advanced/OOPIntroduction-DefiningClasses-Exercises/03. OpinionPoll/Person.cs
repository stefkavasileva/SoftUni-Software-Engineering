public class Person
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public Person()
    {
        this.Name = "No name";
        this.Age = 1;
    }

    public Person(int age)
    {
        this.Name = "No name";
        this.Age = age;
    }
    public string Name { get; set; }

    public int Age { get; set; }

    public override string ToString()
    {
        return $"{this.Name} - {this.Age}";
    }
}

