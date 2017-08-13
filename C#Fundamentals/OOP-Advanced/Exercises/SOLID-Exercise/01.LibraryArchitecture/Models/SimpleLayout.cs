using System;
using _01.LibraryArchitecture.Interfaces;

namespace _01.LibraryArchitecture.Models
{
    public class SimpleLayout : ILayout
    {
        private DateTime dateTime;

        private string reportLevel;

        private string message;


        public SimpleLayout(DateTime dateTime, string reportLevel, string message)
        {
            this.dateTime = dateTime;
            this.reportLevel = reportLevel;
            this.message = message;
        }

        public string PrintMessage()
        {
            return $" {this.dateTime} - {this.reportLevel} - {this.message} ";
        }
    }
}
