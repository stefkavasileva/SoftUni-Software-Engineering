namespace _05.BookLibrary
{
    using System;

    public class Book
    {
        public Book(string title, string author, string publisher, DateTime releaseDate, string isbnNumber, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBNNumber = isbnNumber;
            this.Price = price;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ISBNNumber { get; set; }

        public decimal Price { get; set; }
    }
}