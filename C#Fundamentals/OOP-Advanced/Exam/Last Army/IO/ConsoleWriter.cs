using System;

class ConsoleWriter : IWriter
{
    public void WriteLine(string output)
    {
        Console.WriteLine(output);
    }
}
