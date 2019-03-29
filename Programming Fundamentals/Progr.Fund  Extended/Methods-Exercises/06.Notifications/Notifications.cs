using System;
using System.Text;

public class Notifications
{
    public static void Main()
    {
        var operationCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < operationCount; i++)
        {
            var isSuccess = Console.ReadLine().Equals("success");
            var operation = Console.ReadLine();
            var message = Console.ReadLine();

            var result = new StringBuilder();
            if (isSuccess)
            {
                result = ShowSuccess(operation, message);
            }
            else
            {
                result = ShowError(operation, int.Parse(message));
            }

            Console.Write(result);
        }
    }

    public static StringBuilder ShowSuccess(string operation, string message)
    {
        var result = new StringBuilder();
        result.AppendLine($"Successfully executed {operation}.");
        result.AppendLine("==============================");
        result.AppendLine($"Message: {message}.");
        return result;
    }

    public static StringBuilder ShowError(string operation, int code)
    {
        var result = new StringBuilder();
        result.AppendLine($"Error: Failed to execute {operation}.");
        result.AppendLine("==============================");
        result.AppendLine($"Error Code: {code}.");
        var reason = code >= 0 ? "Invalid Client Data" : "Internal System Failure";
        result.AppendLine($"Reason: {reason}.");
        return result;
    }
}
