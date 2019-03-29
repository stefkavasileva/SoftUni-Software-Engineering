using System;
using System.Linq;
using System.Text;

public class Phone
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().ToList();
        var contacts = Console.ReadLine().Split().ToList();

        var result = new StringBuilder();

        var comandArgs = Console.ReadLine().Split();
        while (!comandArgs[0].Equals("done"))
        {
            var comand = comandArgs[0];

            if (comand.Equals("call"))
            {
                var sum = 0;
                var currentPhone = string.Empty;
                if (comandArgs[1].ToCharArray().Any(x => char.IsDigit(x)))
                {
                    var phone = comandArgs[1];

                    sum = phone.Where(x => char.IsDigit(x)).Select(x => (int)char.GetNumericValue(x)).Sum();
                    var index = numbers.IndexOf(phone);
                    result.AppendLine($"calling {contacts[index]}...");
                }
                else
                {
                    var name = comandArgs[1];
                    var index = contacts.IndexOf(name);
                    sum = numbers[index].Where(x => char.IsDigit(x)).Select(x => (int)char.GetNumericValue(x)).Sum();
                    result.AppendLine($"calling {numbers[index]}...");
                }

                if (sum % 2 != 0)
                {
                    result.AppendLine("no answer");
                }
                else
                {
                    result.AppendLine($"call ended. duration: {sum / 60:00}:{sum % 60:00}");
                }

            }
            else
            {
                var cuurentPhone = string.Empty;
                if (comandArgs[1].ToCharArray().Any(x => char.IsDigit(x)))
                {
                    var phone = comandArgs[1];
                    cuurentPhone = phone;
                    var index = numbers.IndexOf(phone);
                    result.AppendLine($"sending sms to {contacts[index]}...");
                }
                else
                {
                    var name = comandArgs[1];
                    var index = contacts.IndexOf(name);
                    cuurentPhone = numbers[index];
                    result.AppendLine($"sending sms to {numbers[index]}...");
                }

                var diff = 0;
                for (int i = 0; i < cuurentPhone.Length; i++)
                {
                    if (char.IsDigit(cuurentPhone[i]))
                    {
                        var currentNum = (int)char.GetNumericValue(cuurentPhone[i]);
                        diff -= currentNum;
                    }
                }

                if (diff % 2 == -1)
                {
                    result.AppendLine("busy");
                }
                else
                {
                    result.AppendLine("meet me there");
                }
            }

            comandArgs = Console.ReadLine().Split();
        }

        Console.Write(result);
    }
}