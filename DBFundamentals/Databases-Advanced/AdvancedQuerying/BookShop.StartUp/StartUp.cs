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
                //var categories = Console.ReadLine();
                //var books = GetBooksByCategory(db, categories);
                //Console.WriteLine(books);


                //======6. Released Before Date////
                //var dateAsStr = Console.ReadLine();
                //var result = GetBooksReleasedBefore(db, dateAsStr);
                //Console.WriteLine(result);

                //============7. Author Search=============///
                //var input = Console.ReadLine();
                //var result = GetAuthorNamesEndingIn(db, input);
                //Console.WriteLine(result);

                //=============8. Book Search============//
                //var input = Console.ReadLine();
                //var result = GetAuthorNamesEndingIn(db, input);
                //Console.WriteLine(result);

                //=========9. Book Search by Author=======//
                //var input = Console.ReadLine();
                //var result = GetBooksByAuthor(db, input);
                //Console.WriteLine(result);

                //===========10. Count Books===========//
                //var length = int.Parse(Console.ReadLine());
                //var bookCount = CountBooks(db, length);
                //Console.WriteLine(bookCount);

                //=============11. Total Book Copies=========//
                //var result = CountCopiesByAuthor(db);
                //Console.WriteLine(result);

                //============12. Profit by Category========//
                //var result = GetTotalProfitByCategory(db);
                //Console.WriteLine(result);

                //==========13. Most Recent Books======///
                //var result = GetMostRecentBooks(db);
                //Console.WriteLine(result);

                //===========14. Increase Prices============///

                //==========15. Remove Books=======///
                Console.WriteLine(RemoveBooks(db));

            }
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var currentBooks = context
                .Books
                .Where(b => b.Copies < 4200)
                .ToList();

            context.Books.RemoveRange(currentBooks);
             context.SaveChanges();
            return currentBooks.Count;
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var currentBooks = context
                .Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ToList();

            currentBooks.ForEach(b => b.Price = b.Price + 5);
            context.SaveChanges();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            var categories = context
                .Categories
                .Include(c => c.CategoryBooks)
                .ThenInclude(cb => cb.Book)
                .OrderBy(c => c.CategoryBooks.Count)
                .ThenBy(c => c.Name)
                .Select(c => new
                {
                    CategoryName = c.Name,
                    Book = c.CategoryBooks
                    .OrderByDescending(b => b.Book.ReleaseDate)
                    .Take(3)
                    .Select(b => new
                    {
                        BookTitle = b.Book.Title,
                        ReleaseYear = b.Book.ReleaseDate.Value.Year
                    })
                    .ToList()
                })
                .ToList();

            foreach (var category in categories)
            {
                sb.AppendLine($"--{category.CategoryName}");
                category.Book.ForEach(b => sb.AppendLine($"{b.BookTitle} ({b.ReleaseYear})"));
            }

            return sb.ToString().Trim();
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var sb = new StringBuilder();

            var categoryProfits = context
                .Categories
                .Include(c => c.CategoryBooks)
                .ThenInclude(cb => cb.Book)
                .Select(c => new
                {
                    Name = c.Name,
                    Profit = c.CategoryBooks.Sum(b => b.Book.Copies * b.Book.Price)
                })
                .OrderByDescending(c => c.Profit)
                .ThenBy(c => c.Name)
                .ToList();

            categoryProfits.ForEach(c => sb.AppendLine($"{c.Name} ${c.Profit}"));

            return sb.ToString().Trim();
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var sb = new StringBuilder();

            var authorBooks = context
                .Authors
                .Include(a => a.Books)
                .Select(a => new
                {
                    AuthorName = $"{a.FirstName} {a.LastName}",
                    BookCopies = a.Books.Sum(b => b.Copies)

                })
                .OrderByDescending(a => a.BookCopies)
                .ToList();

            authorBooks.ForEach(a => sb.AppendLine($"{a.AuthorName} - {a.BookCopies}"));

            return sb.ToString().Trim();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var bookCount = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();

            return bookCount;
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var titles = context.Books
                .Include(b => b.Author)
                .OrderBy(b => b.BookId)
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .Select(b => new
                {
                    Title = b.Title,
                    AuthorName = $"{b.Author.FirstName} {b.Author.LastName}",
                })
                .ToList();

            titles.ForEach(b => sb.AppendLine($"{b.Title} ({b.AuthorName})"));

            return sb.ToString().Trim();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var titles = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .Select(b => new
                {
                    Title = b.Title
                })
                .OrderBy(b => b.Title)
                .ToList();

            titles.ForEach(b => sb.AppendLine(b.Title));

            return sb.ToString().Trim();
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

            var categoryNames = input.ToLower().Split();

            var bookTitles = context.Books
                .Include(b => b.BookCategories)
                .Where(b => b.BookCategories.Any(c => categoryNames.Contains(c.Category.Name.ToLower())))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList();

            bookTitles.ForEach(b => sb.AppendLine(b));

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
