using System;

namespace BashSoft.Exceptions
{
    public class InvalidStringException : Exception
    {
        private const string NullOrEmptyValue = "The property name is required.";

        public InvalidStringException()
            : base(NullOrEmptyValue)
        {

        }

        public InvalidStringException(string message)
            : base(message)
        {
        }
    }
}
