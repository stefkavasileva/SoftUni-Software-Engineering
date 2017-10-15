using System;
using System.Reflection;

public class AmmunitionFactory
{
    public IAmmunition CreateAmmunition(string name, double weight)
    {
        Type type = Type.GetType("IAmmunition");
        ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string), typeof(double), typeof(double) });
        return (IAmmunition)constructor.Invoke(new object[] { name, weight });
    }

    //public  IAmmunition CreateAmmunition(string name, double weight, double wearLevel)
    //{
    //    switch (name)
    //    {
    //        //case "BulletproofVest":
    //        //    return new BulletproofVest()
    //        //case "Grenades":
    //        //   return new Grenades(name);
    //        case "Helmet":
    //            return new Helmet(name, weight, wearLevel);
    //        case "Knife":
    //            return new Knife(name, weight, wearLevel);
    //        case "NightVision":
    //            return new NightVision(name, weight, wearLevel);
    //        //case "Shield":
    //        //    return new Shield(name, weight, wearLevel);
    //        case "AutomaticMachine":
    //            return new AutomaticMachine(name, weight, wearLevel);
    //        case "Gun":
    //            return new Gun(name, weight, wearLevel);
    //        case "MachineGun":
    //            return new MachineGun(name, weight, wearLevel);
    //        case "RPG":
    //            return new RPG(name, weight, wearLevel);

    //    }
    //    //if none of the above did not match it will be RPG
    //    throw new NotImplementedException();
    //}

    //    public static IAmmunition CreateAmmunitions(string name, int number)
    //    {
    //        switch (name)
    //        {
    //            case "BulletproofVest":
    //                return new BulletproofVest(name, number);
    //            case "Grenades":
    //                return new Grenades(name, number);
    //            case "Helmet":
    //                return new Helmet(name, number);
    //            case "Knife":
    //                return new Knife(name, number);
    //            case "NightVision":
    //                return new NightVision(name, number);
    //            case "Shield":
    //                return new Shield(name, number);
    //            case "AutomaticMachine":
    //                return new AutomaticMachine(name, number);
    //            case "Gun":
    //                return new Gun(name, number);
    //            case "MachineGun":
    //                return new MachineGun(name, number);
    //        }
    //        //if none of the above did not match it will be RPG
    //        return new RPG(name, number);
    //    }
}
