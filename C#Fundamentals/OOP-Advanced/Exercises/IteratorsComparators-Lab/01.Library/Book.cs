using System.Collections.Generic;

public class Book 
{
    public string Title { get; set; }
    public int Year { get; set; }
    public IReadOnlyList<string> Authors { get; set; }

    public Book(string title, int year, params  string[] authors)
    {
        this.Title = title;
        this.Year = year;
        this.Authors = authors;
    }

    public int CompareTo(Book other)
    {
        if (this.Year != other.Year)
        {
            return this.Year.CompareTo(other.Year);
        }

        if (this.Title != other.Title)
        {
            return this.Title.CompareTo(other.Title);
        }

        return 0;
    }

    public override string ToString()
    {
        return $"{this.Title} - {this.Year}";
    }
}

