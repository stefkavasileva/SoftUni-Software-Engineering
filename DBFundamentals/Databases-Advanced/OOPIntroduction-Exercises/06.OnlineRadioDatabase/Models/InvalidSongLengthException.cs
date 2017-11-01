public class InvalidSongLengthException : InvalidSongException
{
    public override string Message => Constants.InvalidSongLength;
}
