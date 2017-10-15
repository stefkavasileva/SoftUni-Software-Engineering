using System;

class ConsoleReader : IReader
{
    public string ReadLine()
    {
        return Console.ReadLine();
    }
}