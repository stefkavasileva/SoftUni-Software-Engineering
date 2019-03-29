namespace _09.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class BookLibrary
    {
        public static void Main()
        {
            var booksCount = int.Parse(Console.ReadLine());

            var books = new List<Book>();

            books = ReadBooks(booksCount);

            var booksPrice = new Dictionary<string, decimal>();

            var library = new Library("DefaultLibrary", books);

            GetBooksPrice(library.Books, booksPrice);

            booksPrice = booksPrice
                 .OrderByDescending(x => x.Value)
                 .ThenBy(x => x.Key)
                 .ToDictionary(x => x.Key, x => x.Value);

            File.WriteAllText("output.txt", string.Empty);

            foreach (var book in booksPrice)
            {
                File.AppendAllText("output.txt", $"{book.Key} -> {book.Value:f2}{Environment.NewLine}");
            }
        }

        private static void GetBooksPrice(List<Book> books, Dictionary<string, decimal> booksPrice)
        {
            foreach (var book in books)
            {
                if (!booksPrice.ContainsKey(book.Author))
                {
                    booksPrice.Add(book.Author, 0.0m);
                }

                booksPrice[book.Author] += book.Price;
            }
        }

        private static List<Book> ReadBooks(int booksCount)
        {
            var books = new List<Book>();

            for (int i = 0; i < booksCount; i++)
            {
                var booksArgs = Console.ReadLine().Split().ToArray();
                var title = booksArgs[0];
                var author = booksArgs[1];
                var publisher = booksArgs[2];
                var releaseDate = booksArgs[3];
                var isbnNumber = booksArgs[4];
                var price = decimal.Parse(booksArgs[5]);

                var currrentBook = new Book(title, author, publisher, releaseDate, isbnNumber, price);

                books.Add(currrentBook);
            }

            return books;
        }
    }
}
