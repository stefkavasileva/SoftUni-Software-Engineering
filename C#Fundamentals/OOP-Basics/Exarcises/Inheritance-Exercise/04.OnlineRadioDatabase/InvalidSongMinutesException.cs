public class InvalidSongMinutesException : InvalidSongLengthException
{
    private const int MinMinutesValue = 0;
    private const int MaxMinutesValue = 14;

    public override string Message => $"Song minutes should be between {MinMinutesValue} and {MaxMinutesValue}.";
}
