using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var soldiers = new SoldiersList();
        var king = new King(Console.ReadLine());
        var royalGuardsNames = Console.ReadLine().Split();

        foreach (string guardName in royalGuardsNames)
        {
            var currentRoyalGuard = new RoyalGuard(guardName, king);
            soldiers.Add(currentRoyalGuard);
            king.BeingAttacked += currentRoyalGuard.OnKingBeingAttacked;
        }

        var footmenNames = Console.ReadLine().Split();

        foreach (string footManName in footmenNames)
        {
            var footMan = new Footman(footManName, king);
            soldiers.Add(footMan);
            king.BeingAttacked += footMan.OnKingBeingAttacked;
        }

        soldiers.ForEach(s => s.SoldierKilled += soldiers.OnSoldierKilled);

        var command = Console.ReadLine().Split();

        while (!command[0].Equals("End"))
        {
            switch (command[0])
            {
                case "Kill":

                    var attackedSoldier = soldiers.FirstOrDefault(s => s.Name.Equals(command[1]));
                    attackedSoldier.TakeAttack();
                    break;

                case "Attack":

                    king.TakeAttack();
                    break;
            }

            command = Console.ReadLine().Split();
        }
    }
}
