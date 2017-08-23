using System;
using System.Linq;
using System.Reflection;

public class Startup
{
    public static void Main()
    {
        var classType = typeof(BlackBoxInt);
        var methodsInfo = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
        var instance = (BlackBoxInt)Activator.CreateInstance(classType, true);

        var input = Console.ReadLine();
        while (!input.Equals("END"))
        {
            var lineArgs = input.Split('_');
            var currentMethod = methodsInfo.FirstOrDefault(x => x.Name.Equals(lineArgs[0]));
            currentMethod.Invoke(instance, new object[] { int.Parse(lineArgs[1]) });

            var innerValue = classType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).FirstOrDefault(x => x.Name.Equals("innerValue")).GetValue(instance);

            Console.WriteLine(innerValue);
            input = Console.ReadLine();
        }
    }
}
