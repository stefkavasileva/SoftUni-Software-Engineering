using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Input;

public class SoldiersFactory
{
    //name, age, experience, speed, endurance,
    public ISoldier CreateSoldier(string name, int age, double experience, double endurance)
    {
        Type type = Type.GetType("ISoldier");
        ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string), typeof(int), typeof(double), typeof(double) });
        return (ISoldier)constructor.Invoke(new object[] { name, age, experience, endurance });
    }

    //public ISoldier GenerateSoldier(string name)
    //{
    //    switch (name)
    //    {
    //            ISoldier instance = null;
    //        case "Corporal":
    //            Activ
    //            return new Corporal(name);


    //    }
    //}
    //name, age, experience, speed, endurance, motivation, maxWeight
    //public ISoldier GenerateRanker(string name, int age, int experience, double endurance)
    //{
    //    return new Ranker(name, age, experience, endurance);
    //}

    //public Soldier GenerateCorporal(string name, int age, int experience, double endurance)
    //{
    //    return new Corporal(name, age, experience, endurance);
    //}

    //public Soldier GenerateSpecialForce(string name, int age, int experience, double endurance)
    //{
    //    return new SpecialForce(name, age, experience, endurance);
    //}
}
