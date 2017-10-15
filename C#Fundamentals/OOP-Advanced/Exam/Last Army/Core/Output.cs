using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public  class Output
{
    public  string GiveOutput( Dictionary<string, IList<ISoldier>> army,
        IDictionary<string, IList<IAmmunition>> wearHouse, int missionQueueCount)
    {
        var result = new StringBuilder();
        var orderedArmy = army.OrderBy(s => s.Value.Average(a => a.Endurance));// towa nz dali trqbwa da e  taka 
        int totalAmmunitions = 0;

        foreach (var team in orderedArmy)
        {
            //result.Append(team.Value[0].ToString());
            //result.AppendLine($"Average experience: {team.Value.Average(e => e.Experience):F2}");
            //result.AppendLine($"Average power: {team.Value.Average(p => p.):F2}");
            result.Append("Soldiers: ");

            foreach (var soldier in team.Value)
            {
                //result.Append($"{soldier.Name} {soldier.Age}, ");
                result.AppendLine(soldier.ToString());
            }

            //result.Remove(result.Length - 2, 2);
            //result.AppendLine(Environment.NewLine);
        }

        //TODO: трябва да ги подредя, защото в момента се чупи
        //var orderedWearHouse = wearHouse.OrderBy(w => w.Value.OrderBy(q => q.Number));
        //result.AppendLine("Weapons:");

        //foreach (var weapons in orderedWearHouse)
        //{
        //    foreach (var weapon in weapons.Value)
        //    {
        //        result.AppendLine(weapon.ToString());
        //        totalAmmunitions += weapon.Number;
        //    }
        //}

        result.AppendLine($"Ammunitions left in total: {totalAmmunitions}");
        result.AppendLine($"Missions left in Queue: {missionQueueCount}");
        return result.ToString().Trim();
    }
}
