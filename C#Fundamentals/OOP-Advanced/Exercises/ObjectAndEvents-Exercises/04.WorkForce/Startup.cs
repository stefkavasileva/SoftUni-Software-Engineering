using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var jobs = new JobsList();
        var employees = new List<IEmployee>();

        var input = Console.ReadLine().Split();

        while (!input[0].Equals("End"))
        {
            switch (input[0])
            {
                case "Job":
                    var currentJob = new Job(input[1], int.Parse(input[2]), employees.FirstOrDefault(e => e.Name.Equals(input[3])));
                    jobs.Add(currentJob);
                    currentJob.JobDone += jobs.OnJobDone;
                    break;

                case "StandartEmployee":
                    var standartEmployee = new StandartEmployee(input[1]);
                    employees.Add(standartEmployee);
                    break;

                case "PartTimeEmployee":
                    var parttimeEmployee = new PartTimeEmployee(input[1]);
                    employees.Add(parttimeEmployee);
                    break;

                case "Pass":

                    foreach (Job job in jobs.ToArray())
                    {
                        job.Update();
                    }

                    break;

                case "Status":

                    foreach (Job job in jobs)
                    {
                        Console.WriteLine(job);
                    }

                    break;
            }

            input = Console.ReadLine().Split();
        }
    }
}
