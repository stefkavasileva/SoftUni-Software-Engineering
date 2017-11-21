using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BookShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop
{
    using BookShop.Data;
    using BookShop.Initializer;

    public class StartUp
    {
        static void Main()
        {
            using (var db = new BookShopContext())
            {
                //DbInitializer.ResetDatabase(db);

                //======1.Age Restriction ========///
                //var ageRestrictAsStr = Console.ReadLine();
                //var booksTitle = GetBooksByAgeRestriction(db, ageRestrictAsStr);
                //Console.WriteLine(booksTitle);

                //===========2. Golden Books===========///
                //var goldenBookTitles = GetGoldenBooks(db);
                //Console.WriteLine(goldenBookTitles);

                //===========3. Books by Price==========//
                //var bookWithPrice = GetBooksByPrice(db);
                //Console.WriteLine(bookWithPrice);

                //===========4. Not Released In===========///
                //var year = int.Parse(Console.ReadLine());
                //var bookTitles = GetBooksNotRealeasedIn(db, year);
                //Console.WriteLine(bookTitles);

                //=============5. Book Titles by Category=======//
                var categories = Console.ReadLine();
                var books = GetBooksByCategory(db, categories);
                Console.WriteLine(books);

                //======6. Released Before Date////
                //var dateAsStr = Console.ReadLine();
                //var result = GetBooksReleasedBefore(db, dateAsStr);
                //Console.WriteLine(result);

                //============7. Author Search=============///
                //var input = Console.ReadLine();
                //var result = GetAuthorNamesEndingIn(db, input);
                //Console.WriteLine(result);
            }
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var authors = context.Authors
                .Where(a => a.FirstName.EndsWith(input))
                .Select(a => new
                {
                    FullName = $"{a.FirstName} {a.LastName}"
                })
                .OrderBy(a => a.FullName)
                .ToList();

            authors.ForEach(a => sb.AppendLine(a.FullName));

            return sb.ToString().Trim();
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var sb = new StringBuilder();
            var format = "dd-MM-yyyy";
            var currentDate = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);

            var books = context.Books
                .Where(b => b.ReleaseDate != null && b.ReleaseDate.Value < currentDate)
                .OrderByDescending(b => b.ReleaseDate.Value)
                .Select(b => new
                {
                    b.Title,
                    b.EditionType,
                    b.Price
                })
                .ToList();

            books.ForEach(b => sb.AppendLine($"{b.Title} - {b.EditionType} - ${b.Price:F2}"));
            return sb.ToString().Trim();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var categoryNames = input.Split();
            var books = new List<BookCategory>();
            foreach (var categoryName in categoryNames)
            {
                books.AddRange(context
                    .Categories
                    .First(c => c.Name.ToLower() == categoryName.ToLower())
                    .CategoryBooks);
            }

            var result = books
                .Select(b => new
                {
                    b.Book.Title
                })
                .OrderBy(b => b.Title)
                .ToList();

            result.ForEach(b=>sb.AppendLine(b.Title));
            return sb.ToString().Trim();
        }

        public static string GetBooksNotRealeasedIn(BookShopContext context, int year)
        {
            var sb = new StringBuilder();

            var bookTitles = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.GetValueOrDefault().Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            bookTitles.ForEach(b => sb.AppendLine(b));

            return sb.ToString().Trim();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var sb = new StringBuilder();

            var booksWithPrice = context.Books
                .Where(b => b.Price > 40)
                .Select(b => new
                {
                    b.Title,
                    b.Price
                })
                .OrderByDescending(b => b.Price)
                .ToList();

            booksWithPrice.ForEach(b => sb.AppendLine($"{b.Title} - ${b.Price:f2}"));

            return sb.ToString().Trim();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            var goldenBookTitles = context.Books
                .Where(b => b.Copies < 5000 && b.EditionType.Equals(EditionType.Gold))
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            goldenBookTitles.ForEach(b => sb.AppendLine(b));

            return sb.ToString().Trim();
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var sb = new StringBuilder();

            var ageRestriction = Enum.Parse(typeof(AgeRestriction), command, true);
            var booksTitle = context.Books
                .Where(b => b.AgeRestriction.Equals(ageRestriction))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList();

            booksTitle.ForEach(b => sb.AppendLine(b));
            return sb.ToString().Trim();
        }
    }
}
