using System;
using _01.LibraryArchitecture.Interfaces;

namespace _01.LibraryArchitecture.Models
{
    public class ConsoleAppender : IAppender
    {
        public void AppendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
