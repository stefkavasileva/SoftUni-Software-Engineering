namespace _06.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using _05.BookLibrary;

    public class BookLibraryModification
    {
        public static void Main()
        {
            var booksCount = int.Parse(Console.ReadLine());
            var books = ReadBooks(booksCount);

            var dateAsStr = Console.ReadLine();
            var date = DateTime.ParseExact(dateAsStr, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            books = books
                .Where(x => x.ReleaseDate > date)
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Title)
                .ToList();

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
        }

        public static List<Book> ReadBooks(int booksCount)
        {
            var books = new List<Book>();

            for (int i = 0; i < booksCount; i++)
            {
                var booksArgs = Console.ReadLine().Split().ToArray();
                var title = booksArgs[0];
                var author = booksArgs[1];
                var publisher = booksArgs[2];
                var releaseDate = DateTime.ParseExact(booksArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbnNumber = booksArgs[4];
                var price = decimal.Parse(booksArgs[5]);

                var currrentBook = new Book(title, author, publisher, releaseDate, isbnNumber, price);

                books.Add(currrentBook);
            }

            return books;
        }
    }
}