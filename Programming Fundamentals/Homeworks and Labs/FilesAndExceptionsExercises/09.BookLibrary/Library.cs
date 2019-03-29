namespace _09.BookLibrary
{
    using System.Collections.Generic;

    public class Library
    {
        public Library(string name, List<Book> books)
        {
            this.Name = name;
            this.Books = books;
        }

        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}