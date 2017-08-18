using System;

public class Footman : Soldier
{
    public Footman(string name)
        : base(name)
    {
    }

    public override void OnKingBeingAttacked(object source, EventArgs args)
    {
        Console.WriteLine($"Footman {this.Name} is panicking!");
    }
}