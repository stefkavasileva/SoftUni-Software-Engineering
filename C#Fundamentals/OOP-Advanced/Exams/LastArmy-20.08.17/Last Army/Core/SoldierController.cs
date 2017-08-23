using System.Collections.Generic;
using System.Linq;

public class SoldierController
{
    //провери в условието какво се случва след успешна мисия с войниците по някакъв начин променят ли се 
    //техните стойности
    public void SoldierChangesAfterSuccessfulMission(IDictionary<string, IList<ISoldier>> army, IMission mission, string rankerType)
    {
        foreach (var soldier in army[rankerType])
        {
            //soldier.Motivation -= mission.DecreasingMotivation;
            //soldier.Endurance -= mission.DecreasingEndurance;
           // soldier.IncreaseSuccessMissionCounter();
        }
    }

    //провери в условието какво се случва след провалена мисия с войниците по някакъв начин променят ли се 
    //техните стойности

    public void SoldierChangesAfterFailedMission(Dictionary<string, List<Soldier>> army,
        Mission mission, string rankerType)
    {
        foreach (var soldier in army[rankerType])
        {
            //soldier.IncreaseFailedMissionCounter();
        }
    }

    //public void TeamGetBonus(Dictionary<string, List<Soldier>> army, string rankerType)
    //{
    //    foreach (var soldiers in army[rankerType])
    //    {
    //        soldiers.GetBonus();
    //    }
    //}

    //public void TeamComesBackFromVacation(Dictionary<string, List<Soldier>> army, string rankerType)
    //{
    //    foreach (var soldiers in army[rankerType])
    //    {
    //        soldiers.ComeBackFromVacation();
    //        soldiers.MakeStatsFull();
    //    }
    //}

    //public void TeamGoesOnVacation(Dictionary<string, List<Soldier>> army, string rankerType)
    //{
    //    foreach (var soldiers in army[rankerType])
    //    {
    //        soldiers.Regenerate();
    //    }
    //}

    public void TeamRegenerate(IDictionary<string, IList<ISoldier>> army, string rankerType)
    {
        //промених го да бъде така защото е ИЛист
        foreach (var soldier in army[rankerType])
        {
            soldier.Regenerate();
        }

        // army[rankerType].ForEach(r => r.Regenerate());
    }

    //public bool CheckSoldiersMotivationAndEndurance(Mission mission, Dictionary<string, List<Soldier>> army, string s)
    //{
    //    if (army[mission.RequiredTeam].Average(m => m.Motivation) < mission.MotivationNeeded
    //        || army[mission.RequiredTeam].Average(e => e.Endurance) < mission.EnduranceRequired)
    //    {
    //        return false;
    //    }
    //    return true;
    //}

        // prowevi trqba li



    //public bool DoWeHaveAllNeededWeaponsForTheMission(IDictionary<string, IList<IAmmunition>> wearHouse,
    //    IDictionary<string, IList<ISoldier>> army, string soldireType, IMission mission)
    //{
    //    foreach (var weapon in mission.MissionWeapons)
    //    {
    //        string weaponName = weapon.Name;

    //        // проверяваме дали изобщо имаме такива оръжия
    //        if (!wearHouse.ContainsKey(weaponName))
    //        {
    //            return false;
    //        }

    //       // int weaponIndex = wearHouse[weaponName].FindIndex(w => w.Name.Equals(weaponName));

    //        ////проверка дали оръжието което се иска от нас, нищо че го има в склада войника е обучен да го използва
    //        //if (!army[soldireType][0].Weapons.Contains(weaponName))
    //        //{
    //        //    return false;
    //        //}
    //        //// проверяваме дали броя оръжия които имаме отговаря на броя на хората в екипа
    //        //if (army[soldireType].Count > wearHouse[weaponName][weaponIndex].Number)
    //        //{
    //        //    return false;
    //        //}
    //    }

    //    return true;
    //}

    //public bool CanEverySoldierCarryOnTheNeededWeapons(Dictionary<string, List<Soldier>> army, List<Ammunition> missionWeapons, string soldierGroup)
    //{
    //    foreach (var soldier in army[soldierGroup])
    //    {
    //        if (!soldier.CanCarryWeaponsTotalWeight(missionWeapons))
    //        {
    //            return false;
    //        }
    //    }
    //    return true;
    //}

    //public bool IsTheTeamOnVacation(Dictionary<string, List<Soldier>> army, string soldierGroup)
    //{
    //    foreach (var soldier in army[soldierGroup])
    //    {
    //        if (soldier.OnVacation)
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}
}
