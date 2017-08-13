using System;
using _01.LibraryArchitecture.Interfaces;

namespace _01.LibraryArchitecture.Models
{
    public class Logger :ILogger
    {
        public void Error(string data, string message)
        {
            Console.WriteLine($"{data} - {message}");
        }

        public void Info(string data, string message)
        {
            Console.WriteLine($"{data} - {message}");
        }

        public void Warnings(string data, string message)
        {
            Console.WriteLine($"{data} - {message}");
        }
    }
}
