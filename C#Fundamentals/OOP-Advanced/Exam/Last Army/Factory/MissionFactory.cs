using System;
using System.Reflection;

class MissionFactory
{
    public IMission CreateMission(string name, int count)
    {
        Type type = Type.GetType("IMission");
        ConstructorInfo constructor = type.GetConstructor(new [] { typeof(string) ,typeof(int)});
        return (IMission)constructor.Invoke(new object [] {name, count});            
    }
}

