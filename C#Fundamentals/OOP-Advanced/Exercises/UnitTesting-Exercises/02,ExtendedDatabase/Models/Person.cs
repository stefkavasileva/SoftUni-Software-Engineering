public class Person : IPerson
{
    public Person(string name, int id)
    {
        this.Name = name;
        this.Id = id;
    }

    public string Name { get; protected set; }
    public int Id { get; protected set; }
}
