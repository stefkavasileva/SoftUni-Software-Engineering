public class InvalidSongSecondsException : InvalidSongLengthException
{
    private const int MinSecondsValue = 0;
    private const int MaxSecondsValue = 59;

    public override string Message => string.Format(Constants.InvalidSongSeconds, MinSecondsValue, MaxSecondsValue);
}
