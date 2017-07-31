public class Pet
{
    public Pet(string name, int age, string kind)
    {
        this.Name = name;
        this.Age = age;
        this.Kind = kind;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Kind { get; set; }

    public override string ToString()
    {
        return $"{this.Name} {this.Age} {this.Kind}";
    }
}
