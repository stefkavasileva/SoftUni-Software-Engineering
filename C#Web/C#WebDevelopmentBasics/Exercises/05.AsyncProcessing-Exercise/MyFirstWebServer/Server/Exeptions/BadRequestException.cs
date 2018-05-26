using System;

namespace MyFirstWebServer.Server.Exeptions
{
    public class BadRequestException : Exception
    {
        private string Message { get; }

        public BadRequestException(string message)
        {
            this.Message = message;
        }
    }
}
