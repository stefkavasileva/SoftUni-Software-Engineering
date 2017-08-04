using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string className, params string[] fieldsName)
    {
        var classType = Type.GetType(className);
        var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic |
                                         BindingFlags.Public);

        var classInstance = Activator.CreateInstance(classType, new object[] { });
        var sb = new StringBuilder();

        sb.AppendLine($"Class under investigation: {className}");
        foreach (var field in fields.Where(f => fieldsName.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        var sb = new StringBuilder();

        var classType = Type.GetType(className);
        var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

        foreach (var fieldInfo in fields)
        {
            sb.AppendLine($"{fieldInfo.Name} must be private!");
        }

        var propsGet = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var property in propsGet.Where(x => x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{property.Name} have to be public!");
        }

        var propsSet = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);

        foreach (var property in propsSet.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{property.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        var sb = new StringBuilder();

        var classType = Type.GetType(className);
        var methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (var method in methods)
        {
            sb.AppendLine(method.Name);
        }

        return sb.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {
        var sb = new StringBuilder();

        var classType = Type.GetType(className);
        var methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

        foreach (var methodInfo in methods.Where(x => x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{methodInfo.Name} will return {methodInfo.ReturnType}");
        }

        foreach (var methodInfo in methods.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{methodInfo.Name} will set field of {methodInfo.GetParameters().First().ParameterType}");
        }

        return sb.ToString().Trim();
    }
}

