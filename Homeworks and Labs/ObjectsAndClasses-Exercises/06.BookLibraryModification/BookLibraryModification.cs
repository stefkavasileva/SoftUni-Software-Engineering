using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string ISBN_number { get; set; }
    public decimal Price { get; set; }

    public Book(string title, string author, string punlisher, DateTime releaseDate, string isbnNumber, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Publisher = punlisher;
        this.ReleaseDate = releaseDate;
        this.ISBN_number = isbnNumber;
        this.Price = price;
    }
}

class BookLibraryModification
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
            DateTime releaseDate =DateTime.ParseExact(bookArgs[3],"d.M.yyyy", CultureInfo.InvariantCulture);
            string isbnNumber = bookArgs[4];
            decimal price = decimal.Parse(bookArgs[5]);

            Book currentBook = new Book(titel, author, publisher, releaseDate, isbnNumber, price);

            books.Add(currentBook);
        }

        DateTime date = DateTime
    .ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InstalledUICulture);


Dictionary <string, DateTime> titlesReleased = new Dictionary<string, DateTime>();
        foreach (var book in books)
        {
            if (!titlesReleased.ContainsKey(book.Title) && book.ReleaseDate>date)
            {
                titlesReleased.Add(book.Title, book.ReleaseDate);
            }
        }

        titlesReleased = titlesReleased.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

        foreach (var author in titlesReleased)
        {
            Console.WriteLine($"{author.Key} -> {author.Value.ToString("dd.MM.yyyy")}");
        }
    }
}

