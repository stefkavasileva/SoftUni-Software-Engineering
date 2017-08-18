using System;

public abstract class Soldier : INameable
{
    protected Soldier(string name)
    {
        this.Name = name;
    }

    public string Name { get; }

    public abstract void OnKingBeingAttacked(object source, EventArgs args);
}