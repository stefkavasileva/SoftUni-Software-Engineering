using System;

public class RoyalGuard : Soldier
{
    public RoyalGuard(string name)
        : base(name)
    {
    }

    public override void OnKingBeingAttacked(object source, EventArgs args)
    {
        Console.WriteLine($"Royal Guard {this.Name} is defending!");
    }
}