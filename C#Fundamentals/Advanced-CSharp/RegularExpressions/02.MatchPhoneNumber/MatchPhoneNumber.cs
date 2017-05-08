using System;
using System.Text.RegularExpressions;

public class MatchPhoneNumber
{
    public static void Main()
    {
        var firstReg = new Regex(@"^\+359-\d-\d{3}-\d{4}$");
        var secondReg = new Regex(@"^\+359 \d \d{3} \d{4}$");

        var phone = Console.ReadLine();

        while (!phone.Equals("end"))
        {

            if (firstReg.IsMatch(phone) || secondReg.IsMatch(phone))
            {
                Console.WriteLine(phone);
            }

            phone = Console.ReadLine();
        }
    }
}

