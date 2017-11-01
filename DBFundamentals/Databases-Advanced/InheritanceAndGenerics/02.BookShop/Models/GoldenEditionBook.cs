public class GoldenEditionBook : Book
{
    private const decimal Percentage = 0.3m;

    public GoldenEditionBook(string title, string author, decimal price)
        : base(title, author, price)
    {
        base.Price += this.Price * Percentage;
    }
}

