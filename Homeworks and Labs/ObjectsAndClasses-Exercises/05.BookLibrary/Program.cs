using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public string ReleaseDate{ get; set; }
    public string ISBN_number{ get; set; }
    public decimal Price { get; set; }

    public  Book (string title,string author,string punlisher,string releaseDate, string isbnNumber,decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Publisher = punlisher;
        this.ReleaseDate = releaseDate;
        this.ISBN_number = isbnNumber;
        this.Price = price;
    }
}


class Program
{
    static void Main(string[] args)
    {
        int numberOfBooks = int.Parse(Console.ReadLine());
  
        List<Book> books = new List<Book>();

        for (int i = 0; i < numberOfBooks; i++)
        {
            string[] bookArgs = Console.ReadLine().Split().ToArray();
            string titel = bookArgs[0];
            string author = bookArgs[1];
            string publisher = bookArgs[2];
            string releaseDate = bookArgs[3];
            string isbnNumber = bookArgs[4];
            decimal price =decimal.Parse(bookArgs[5]);

            Book currentBook = new Book(titel, author, publisher, releaseDate, isbnNumber,price);

            books.Add(currentBook);
        }

        Dictionary<string, decimal> authorsPrices = new Dictionary<string, decimal>();
        foreach (var book in books)
        {
            if (!authorsPrices.ContainsKey(book.Author))
            {
                authorsPrices.Add(book.Author, book.Price);
            }
            else
            {
                authorsPrices[book.Author] += book.Price;
            }
        }

        authorsPrices = authorsPrices.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);

        foreach (var author in authorsPrices)
        {
            Console.WriteLine($"{author.Key} -> {author.Value:f2}");
        }


    }
}

