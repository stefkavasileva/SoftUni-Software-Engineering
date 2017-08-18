using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main()
    {
        var soldiers = new List<Soldier>();
        var king = new King(Console.ReadLine());
        var royalGuardsNames = Console.ReadLine().Split();

        foreach (string guardName in royalGuardsNames)
        {
            var currentRoyalGuard = new RoyalGuard(guardName);
            soldiers.Add(currentRoyalGuard);
            king.BeingAttacked += currentRoyalGuard.OnKingBeingAttacked;
        }

        var footmenNames = Console.ReadLine().Split();

        foreach (string footManName in footmenNames)
        {
            var footMan = new Footman(footManName);
            soldiers.Add(footMan);
            king.BeingAttacked += footMan.OnKingBeingAttacked;
        }

        var command = Console.ReadLine().Split();

        while (!command[0].Equals("End"))
        {
            switch (command[0])
            {
                case "Kill":

                    Soldier deadSoldier = soldiers.FirstOrDefault(s => s.Name.Equals(command[1]));
                    king.BeingAttacked -= deadSoldier.OnKingBeingAttacked;
                    soldiers.Remove(deadSoldier);
                    break;

                case "Attack":

                    king.TakeAttack();
                    break;
            }

            command = Console.ReadLine().Split();
        }
    }
}
