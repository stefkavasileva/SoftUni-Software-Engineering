public class Robot : IRobot
{
    public Robot(string name , int age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }

    public string Name { get; }
    public string Id { get; }
    public int Age { get; }
}

