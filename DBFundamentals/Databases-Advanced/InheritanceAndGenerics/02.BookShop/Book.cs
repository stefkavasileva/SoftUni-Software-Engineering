using System;
using System.Text;

public class Book
{
    private string title;
    private string author;
    private decimal price;

    public Book( string author, string title ,decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public string Title
    {
        get => this.title;
        protected set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException(ErrorMessages.InvalidTitle);
            }

           this.title = value;
        }
    }

    public string Author
    {
        get => this.author;
        protected set
        {
            if (char.IsDigit(value[value.IndexOf(" ") + 1]))
            {
                throw new ArgumentException(ErrorMessages.InvaidAuthorName);
            }

            this.author = value;
        }
    }

    public decimal Price
    {
        get => this.price;
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException(ErrorMessages.InvalidPrice);
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Type: {GetType().Name}");
        sb.AppendLine($"Title: {this.Title}");
        sb.AppendLine($"Author: {this.Author}");
        sb.AppendLine($"Price: {this.Price:f2}");

        return sb.ToString().Trim();
    }
}

