using System;
class InvalidPathException : Exception
{
    private const string InvalidPath = "The sorce does not exist.";

    public InvalidPathException()
            : base(InvalidPath)
    {

    }
    public InvalidPathException(string message)
    : base(message)
    {
    }
}

