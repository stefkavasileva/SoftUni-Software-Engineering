using System;

public class RoyalGuard : Soldier
{
    private const int DefaultHits = 3;

    public RoyalGuard(string name, King kingToDefend)
        : base(name, DefaultHits, kingToDefend)
    {
    }

    public override void OnKingBeingAttacked(object source, EventArgs args)
    {
        Console.WriteLine($"Royal Guard {this.Name} is defending!");
    }
}