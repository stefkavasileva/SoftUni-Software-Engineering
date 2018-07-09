namespace BookLibrary.Web.Models
{
    public class BookViewModel
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int AuthorId { get; set; }

        public string Status { get; set; }
    }
}
