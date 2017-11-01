using System;
using System.Text;

public abstract class Animal
{
    private string name;
    private int age;
    private string gender;

    protected Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name
    {
        get => this.name;
        protected set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(ErrorMessages.InvalidInput);
            }

            this.name = value;
        }
    }

    public int Age
    {
        get => this.age;
        protected set
        {
            if (string.IsNullOrWhiteSpace(value.ToString()) || value < 0)
            {
                throw new ArgumentException(ErrorMessages.InvalidInput);
            }

            this.age = value;
        }
    }

    public string Gender
    {
        get => this.gender;
        protected set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(ErrorMessages.InvalidInput);
            }

            this.gender = value;
        }
    }

    public abstract string ProduceSound();

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(GetType().Name);
        sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
        sb.AppendLine(this.ProduceSound());
        return sb.ToString();
    }
}