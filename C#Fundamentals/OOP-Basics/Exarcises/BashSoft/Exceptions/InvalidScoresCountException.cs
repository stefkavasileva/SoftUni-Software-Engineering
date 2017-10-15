using System;

namespace BashSoft.Exceptions
{
    public class InvalidScoresCountException : Exception
    {
        public const string InvalidCount =
            "The number of scores for the given course is greater than the possible.";

        public InvalidScoresCountException()
            : base(InvalidCount)
        {

        }

        public InvalidScoresCountException(string message)
            : base(message)
        {

        }


    }
}
