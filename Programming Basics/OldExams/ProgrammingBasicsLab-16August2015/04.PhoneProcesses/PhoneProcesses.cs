using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PhoneProcesses
{
    static void Main(string[] args)
    {
        //88/100
        string percentageAsStr = Console.ReadLine().Replace("%", "");
        int percentage = int.Parse(percentageAsStr);

        List<string> results = new List<string>();
        bool isTimeToCharge = false;
        bool isPhoneOff = false;

        int appsLeft = 0;
        if (percentage <= 0)
        {
            Console.WriteLine("Phone Off");
            return;
        }

        while (true)
        {
            string inputLine = Console.ReadLine().ToLower();

            if (inputLine.Equals("end"))
            {
                break;
            }

            if (isPhoneOff)
            {
                continue;
            }

            if (isTimeToCharge)
            {
                appsLeft++;
                continue;
            }

            int neededPercentage = int.Parse(inputLine.Substring(inputLine.Length - 3, 2));
            percentage -= neededPercentage;
            if (percentage > 0 && percentage <= 15)
            {
                results.Add("Connect charger -> " + percentage + "%");
                isTimeToCharge = true;
            }
            else if (percentage <= 0 && !isTimeToCharge)
            {
                results.Add("Phone Off");
            }
        }

        if (isTimeToCharge)
        {
            results.Add("Programs left -> " + (appsLeft == 0 ? 1 : appsLeft));
        }
        else if (appsLeft == 0 && !results.Contains("Phone Off"))
        {
            results.Add("Successful complete -> " + percentage + "%");
        }

        foreach (var r in results)
        {
            Console.WriteLine(r);
        }
    }
}

