using System;

public class NameChangeEventArgs : EventArgs
{
    public NameChangeEventArgs(string name)
    {
        this.Name = name;
    }

    public string Name { get; }
}