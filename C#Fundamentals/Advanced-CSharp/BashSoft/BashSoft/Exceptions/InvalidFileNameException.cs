using System;

namespace BashSoft.Exceptions
{
    class InvalidFileNameException : Exception
    {
        private const string ForbiddenSymbolsContainedInName =
            "The given name contains symbols that are not allowed to be used in names of files or folders.";

        public InvalidFileNameException()
            : base(ForbiddenSymbolsContainedInName)
        {

        }

        public InvalidFileNameException(string message)
            : base(message)
        {

        }
    }
}
