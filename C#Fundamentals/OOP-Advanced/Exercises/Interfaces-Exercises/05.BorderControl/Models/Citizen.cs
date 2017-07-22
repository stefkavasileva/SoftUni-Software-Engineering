public class Citizen : IName,IIdentible,IBirthdate
{
    public Citizen(string name , int age,string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public int Age { get;  protected set; }
    public string Id { get; protected set; }
    public string Model { get; protected set; }
    public string Name { get; protected set; }
    public string Birthdate { get; protected set; }
}

