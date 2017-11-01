public class InvalidSongNameException : InvalidSongException
{
    private const int MinNameLength = 3;
    private const int MaxNameLength = 30;

    public override string Message => string.Format(Constants.InvalidSongSymbol, MinNameLength, MaxNameLength);
}
