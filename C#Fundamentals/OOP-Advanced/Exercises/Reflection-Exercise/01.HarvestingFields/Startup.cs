using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Startup
{
    public static void Main()
    {
        var fieslds = new List<FieldInfo>();
        var line = Console.ReadLine();

        while (!line.Equals("HARVEST"))
        {
            if (line.Equals("private"))
            {
                fieslds.AddRange(GetPrivateFields());
            }
            else if (line.Equals("protected"))
            {
                fieslds.AddRange(GetProtectedFields());
            }
            else if (line.Equals("public"))
            {
                fieslds.AddRange(GetPublicdFields());
            }
            else
            {
                fieslds.AddRange(GetAllFields());
            }

            line = Console.ReadLine();
        }

        foreach (var fieldInfo in fieslds)
        {
            Console.WriteLine($"{GetModifire(fieldInfo)} {fieldInfo.FieldType.Name} {fieldInfo.Name}");
        }
    }

    private static object GetModifire(FieldInfo fieldInfo)
    {
        if (fieldInfo.IsPublic)
        {
            return "public";
        }
        else if (fieldInfo.IsPrivate)
        {
            return "private";
        }
        else
        {
            return "protected";
        }
    }

    private static List<FieldInfo> GetAllFields()
    {
        var type = Type.GetType("HarvestingFields");
        var allFields = type.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        return allFields.ToList();
    }

    private static List<FieldInfo> GetPublicdFields()
    {
        return GetAllFields().Where(x => x.IsPublic).ToList();
    }

    private static List<FieldInfo> GetProtectedFields()
    {
        return GetAllFields().Where(x => x.IsFamily).ToList();
    }

    private static List<FieldInfo> GetPrivateFields()
    {
        return GetAllFields().Where(x => x.IsPrivate).ToList();
    }
}
