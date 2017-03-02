using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ProspectInHospitality
{
    static void Main(string[] args)
    {
        long buildersNeeded = long.Parse(Console.ReadLine());
        long receptionistsNeeded = long.Parse(Console.ReadLine());
        long chambermaidsNeeded = long.Parse(Console.ReadLine());
        long techniciansNeeded = long.Parse(Console.ReadLine());
        long otherStuffNeeded = long.Parse(Console.ReadLine());
        decimal salaryInUSD = decimal.Parse(Console.ReadLine());
        decimal currancyRateAtTheMoment = decimal.Parse(Console.ReadLine());
        decimal mySalary = decimal.Parse(Console.ReadLine());
        decimal budget = decimal.Parse(Console.ReadLine());

        decimal totalSalary = 0;
        totalSalary += buildersNeeded * 1500.04m;
        totalSalary += receptionistsNeeded * 2102.10m;
        totalSalary += chambermaidsNeeded * 1465.46m;
        totalSalary += techniciansNeeded * 2053.33m;
        totalSalary += otherStuffNeeded * 3010.98m;
        totalSalary += salaryInUSD * currancyRateAtTheMoment;
        totalSalary += mySalary;

        Console.WriteLine("The amount is: {0:f2} lv.", totalSalary);

        if (totalSalary <= budget)
        {
            decimal diff = budget - totalSalary;
            Console.WriteLine("YES \\ Left: {0:f2} lv.", diff);
        }
        else
        {
            decimal diff = totalSalary - budget;
            Console.WriteLine("NO \\ Need more: {0:f2} lv.", diff);
        }
    }
}

