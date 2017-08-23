using System.Collections.Generic;

public class AmmunitionsController
{
    private IList<string> weaponsForRemoval = new List<string>();

    // Провери в усолвието дали е необходимо да се премахвах уепъните който са със стойност по малка от 0



    //public void DecreaseAmmunitionsWearLevel(IMission mission, IDictionary<string, IList<IAmmunition>> wearHouse)
    //{
    //    string weaponName = string.Empty;

    //    //Трябва да добавиш MissionWeapons в мисията, т.е да промениш интерфейса или да добавиш
    //    //нова функционалност към него, което е възможен бъг .... 
    //    foreach (var weapon in mission.MissionWeapons)
    //    {
    //        weaponName = weapon.Name;
    //        foreach (var ammunition in wearHouse[weaponName])
    //        {
    //            if (weaponName.Equals(ammunition.Name))
    //            {
    //                ammunition.DecreaseWearLevel(mission);
    //            }
    //        }
    //    }
    //}

    //public void ThrowAnyWeaponsWithZeroWearLevel(IDictionary<string, IList<IAmmunition>> wearHouse)
    //{
    //    foreach (var type in wearHouse)
    //    {
    //        foreach (var weapon in type.Value)
    //        {
    //            //Същата история като другия метод добавяш функционалност ??? 
    //            if (weapon.WearLevelIsZero)
    //            {
    //                weaponsForRemoval.Add(type.Key);
    //            }
    //        }
    //    }

    //    for (int i = 0; i < weaponsForRemoval.Count; i++)
    //    {
    //        wearHouse.Remove(weaponsForRemoval[i]);
    //    }
    //    weaponsForRemoval.Clear();
    //}
}