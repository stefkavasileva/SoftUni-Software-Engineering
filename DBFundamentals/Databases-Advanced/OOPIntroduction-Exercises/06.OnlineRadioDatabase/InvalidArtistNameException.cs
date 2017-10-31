public class InvalidArtistNameException : InvalidSongException
{
    private const int MinNameLength = 3;
    private const int MaxNameLength = 30;

    public override string Message => $"Artist name should be between {MinNameLength} and {MaxNameLength} symbols.";
}
