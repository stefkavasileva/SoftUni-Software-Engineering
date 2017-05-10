using System.Collections.Generic;

public class User
{
    public User(string name, List<string> logs)
    {
        this.Name = name;
        this.Logs = logs;
    }
    public string Name { get; set; }

    public List<string> Logs { get; set; }
}

