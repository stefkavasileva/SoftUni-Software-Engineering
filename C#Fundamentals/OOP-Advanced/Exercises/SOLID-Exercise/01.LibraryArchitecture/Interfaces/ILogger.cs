namespace _01.LibraryArchitecture.Interfaces
{
    public interface ILogger
    {
        void Error(string data, string message);

        void Info(string data , string message);

        void Warnings(string data, string message);
    }
}
