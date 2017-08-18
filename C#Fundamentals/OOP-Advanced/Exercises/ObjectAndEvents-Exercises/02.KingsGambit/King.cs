using System;

public class King : INameable
{
    public King(string name)
    {
        this.Name = name;
    }

    public event EventHandler BeingAttacked;

    public string Name { get; set; }

    public void TakeAttack()
    {
        this.OnBeingAttacked();
    }

    protected virtual void OnBeingAttacked()
    {
        Console.WriteLine($"King {this.Name} is under attack!");

        if (this.BeingAttacked != null)
        {
            this.BeingAttacked(this, EventArgs.Empty);
        }
    }
}