using System;

public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                this.name = "No name";
            }

            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            try
            {
                this.age = value;
            }
            catch (Exception invalidException)
            {
                throw new InvalidOperationException();
            }
        }
    }

    public Person()
    {
        this.name = "No name";
        this.age = 1;
    }

    public Person(int age)
        : this()
    {
        this.name = "No name";
        this.age = age;
    }

    public Person(string name, int age)
        : this(age)
    {
        this.name = name;
        this.age = age;
    }
}