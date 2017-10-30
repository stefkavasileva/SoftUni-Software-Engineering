using System;
using System.Text;

public abstract class Human
{
    private string firstName;
    private string lastName;

    protected Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName
    {
        get => this.firstName;
        protected set
        {
            if (char.IsLower(value[0]))
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidName,nameof(firstName)));
            }

            if (value.Length < 4)
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidNameLength,nameof(firstName),3));
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get => this.lastName;
        protected set
        {
            if (char.IsLower(value[0]))
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidName, nameof(lastName)));
            }

            if (value.Length < 3)
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidNameLength, nameof(lastName), 2));
            }

            this.lastName = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.FirstName}");
        sb.AppendLine($"Last Name: {this.LastName}");

        return sb.ToString().Trim();
    }
}
