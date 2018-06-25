namespace WebServer.Exceptions
{
    using System;

    public class UnauthorizedException : Exception
    {
        private const string UnauthorizedMessage = "You are not authorized to perform this task.";

        public static object ThrowFromInvalidRequest()
            => throw new BadRequestException(UnauthorizedMessage);

        public UnauthorizedException(string message)
            : base(message)
        {
        }
    }
}
