using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    public class Startup
    {
        public static void Main()
        {
            var departs = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            var input = Console.ReadLine();

            while (!input.Equals("Output"))
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var departName = tokens[0];
                var doctorName = tokens[1] + " " + tokens[2];
                var patienName = tokens[3];


                if (!departs.ContainsKey(departName))
                {
                    departs.Add(departName, new Dictionary<string, HashSet<string>>());
                }

                if (!departs[departName].ContainsKey(doctorName))
                {
                    departs[departName].Add(doctorName, new HashSet<string>());
                }

                departs[departName][doctorName].Add(patienName);

                input = Console.ReadLine();
            }

            var departsResult = new Dictionary<string,Dictionary<string,List<string>>>();

            foreach (var depart in departs)
            {
                departsResult.Add(depart.Key,new Dictionary<string, List<string>>());
                foreach (var doctor in depart.Value)
                {
                    departsResult[depart.Key].Add(doctor.Key,new List<string>());
                    departsResult[depart.Key][doctor.Key].AddRange(doctor.Value.Take(60));
                }
            }

            input = Console.ReadLine();
            while (!input.Equals("End"))
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var patients = new List<string>();
                if (tokens.Length == 2 && tokens[1].All(x => !char.IsDigit(x)))
                {        
                    foreach (var depart in departsResult)
                    {
                        foreach (var doctorName in depart.Value)
                        {
                            if (doctorName.Key.Equals(tokens[0] + " " + tokens[1]))
                            {
                                patients.AddRange(doctorName.Value);
                            }
                        }
                    }

                    Console.WriteLine(string.Join(Environment.NewLine, patients.OrderBy(x => x)));
                }
                else if (tokens.Length == 2)
                {
                    if (departsResult.ContainsKey(tokens[0]))
                    {
                        foreach (var patientsInDep in departsResult[tokens[0]])
                        {
                            patients.AddRange(patientsInDep.Value);
                        }
                    }

                    if (patients.Any())
                    {
                        Console.WriteLine(string.Join(Environment.NewLine, patients.Skip(3 * (int.Parse(tokens[1]) - 1)).Take(3).OrderBy(x => x)));
                    }
                }
                else
                {
                    if (departsResult.ContainsKey(tokens[0]))
                    {
                        foreach (var patientsInDep in departs[tokens[0]])
                        {
                            patients.AddRange(patientsInDep.Value);
                        }
                    }

                    if (patients.Any())
                    {
                        Console.WriteLine(string.Join(Environment.NewLine, patients.Take(60)));
                    }
                }

                input = Console.ReadLine();
            }

        }
    }
}
