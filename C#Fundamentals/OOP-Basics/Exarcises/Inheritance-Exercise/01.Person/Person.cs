using System;
using System.Text;

public class Person
{
    private int age;
    private string name;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public virtual int Age
    {
        get => this.age;
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }

            this.age = value;
        }
    }

    public virtual string Name
    {
        get => this.name;
        protected set
        {
            if (value.Length < 3 || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name's length should not be less than 3 symbols!");
            }

            this.name = value;
        }
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"Name: {this.Name}, Age: {this.Age}");

        return stringBuilder.ToString();
    }

}
