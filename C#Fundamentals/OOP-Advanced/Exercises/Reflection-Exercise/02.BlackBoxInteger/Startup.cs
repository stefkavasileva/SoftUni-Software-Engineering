using System;
using System.Linq;
using System.Reflection;

public class Startup
{
    public static void Main()
    {
        var classType = typeof(BlackBoxInt);
        var flags = BindingFlags.NonPublic | BindingFlags.Instance;

        var blackBox = (BlackBoxInt)Activator.CreateInstance(classType, true);

        string command = Console.ReadLine();

        while (!command.Equals("END"))
        {
            var args = command.Split('_');
            var methodName = args[0];
            var passedValue = int.Parse(args[1]);

            var currentMethod = classType.GetMethod(methodName, flags);

            currentMethod.Invoke(blackBox, new object[] { passedValue });

            var innerValue = classType.GetFields(flags).First().GetValue(blackBox).ToString();
            Console.WriteLine(innerValue);

            command = Console.ReadLine();
        }
    }
}
