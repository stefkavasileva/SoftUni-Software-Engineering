using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Startup
{
    public static void Main()
    {
        var fieldsInfo = new List<FieldInfo>();

        var input = Console.ReadLine();
        while (!input.Equals("HARVEST"))
        {
            fieldsInfo.AddRange(GetCurrentFields(input));
            input = Console.ReadLine();
        }

        foreach (var fieldInfo in fieldsInfo)
        {
            Console.WriteLine($"{GetModifire(fieldInfo)} {fieldInfo.FieldType.Name} {fieldInfo.Name}");
        }
    }

    private static string GetModifire(FieldInfo fieldInfo)
    {
        if (fieldInfo.IsPublic)
        {
            return "public";
        }

        if (fieldInfo.IsPrivate)
        {
            return "private";
        }

        return "protected";
    }

    private static IEnumerable<FieldInfo> GetCurrentFields(string input)
    {
        var type = Type.GetType("HarvestingFields");
        var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
        switch (input)
        {
            case "private":
                fields = fields.Where(x => x.IsPrivate).ToArray();
                break;
            case "protected":
                fields = fields.Where(x => x.IsFamily).ToArray();
                break;
            case "public":
                fields = fields.Where(x => x.IsPublic).ToArray();
                break;
        }

        return fields;
    }
}
