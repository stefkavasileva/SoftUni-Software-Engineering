using System;
using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    private Dictionary<int, Car> registeredCars = new Dictionary<int, Car>();
    private Dictionary<int, Race> openedRaces = new Dictionary<int, Race>();
    private Garage garage = new Garage(new List<Car>());

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        if (type.Equals("Performance"))
        {
            registeredCars.Add(id, new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
        }
        else if (type.Equals("Show"))
        {
            registeredCars.Add(id,
                new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
        }
        else
        {
            throw new ArgumentException($"Invalid type of a car");
        }
    }

    public string Check(int id)
    {
        if (!registeredCars.ContainsKey(id))
        {
            throw new KeyNotFoundException();
        }

        return registeredCars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool, int param)
    {
        if (type.Equals("TimeLimit"))
        {
            openedRaces.Add(id, new TimeLimitRace(length, route, prizePool, param));
        }
        else if (type.Equals("Circuit"))
        {
            openedRaces.Add(id, new CircuitRace(length, route, prizePool, param));
        }
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        if (type.Equals("Casual"))
        {
            openedRaces.Add(id, new CasualRace(length, route, prizePool));
        }
        else if (type.Equals("Drag"))
        {
            openedRaces.Add(id, new DragRace(length, route, prizePool));
        }
        else if (type.Equals("Drift"))
        {
            openedRaces.Add(id, new DriftRace(length, route, prizePool));
        }
        else
        {
            throw new ArgumentException($"Invalid type of a race");
        }
    }

    public void Participate(int carId, int raceId)
    {
        var currentCar = registeredCars[carId];
        if (!garage.ParkedCars.Any(x => x.Equals(currentCar)))
        {
            var currentRace = openedRaces[raceId];

            if (currentRace.GetType().Name.Equals("TimeLimitRace") && currentRace.Participants.Count != 0)
            {
                return;
            }

            currentRace.Participants.Add(currentCar);
        }
    }

    public string Start(int raceId)
    {
        if (openedRaces[raceId].Participants.Any())
        {
            var result = openedRaces[raceId].ToString();
            openedRaces.Remove(raceId);
            return result;

        }

        return "Cannot start the race with zero participants.";
    }

    public void Park(int carId)
    {
        var currentCar = registeredCars[carId];
        if (!openedRaces.Any(x => x.Value.Participants.Any(y => y.Equals(currentCar))))
        {
            garage.ParkedCars.Add(registeredCars[carId]);
        }
    }

    public void Unpark(int id)
    {
        garage.ParkedCars.Remove(registeredCars[id]);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        if (garage.ParkedCars.Any())
        {
            foreach (var parkingCar in garage.ParkedCars)
            {
                parkingCar.Horsepower += tuneIndex;
                parkingCar.Suspension += tuneIndex / 2;
                if (parkingCar.GetType().Name.Equals("ShowCar"))
                {
                    parkingCar.Stars += tuneIndex;
                }
                else
                {
                    parkingCar.AddOns.Add(addOn);
                }
            }
        }

    }

    public void CommandInterpreter(string inputLine)
    {
        var tokens = inputLine.Split();
        var comandName = tokens[0];
        switch (comandName)
        {
            case "register":
                var id = int.Parse(tokens[1]);
                var type = tokens[2];
                var brand = tokens[3];
                var model = tokens[4];
                var year = int.Parse(tokens[5]);
                var horsepower = int.Parse(tokens[6]);
                var acceleration = int.Parse(tokens[7]);
                var suspension = int.Parse(tokens[8]);
                var durability = int.Parse(tokens[9]);

                this.Register(id, type, brand, model, year, horsepower, acceleration, suspension, durability);
                break;
            case "check":
                var result = this.Check(int.Parse(tokens[1]));
                Console.WriteLine(result);
                break;
            case "open":
                if (inputLine.Split().Length > 5)
                {
                    this.Open(int.Parse(tokens[1]), tokens[2], int.Parse(tokens[3]), tokens[4], int.Parse(tokens[5]), int.Parse(tokens[6]));
                    break;
                }

                this.Open(int.Parse(tokens[1]), tokens[2], int.Parse(tokens[3]), tokens[4], int.Parse(tokens[5]));
                break;
            case "participate":
                this.Participate(int.Parse(tokens[1]), int.Parse(tokens[2]));
                break;
            case "start":
                Console.WriteLine(this.Start(int.Parse(tokens[1])));
                break;
            case "park":
                this.Park(int.Parse(tokens[1]));
                break;
            case "unpark":
                this.Unpark(int.Parse(tokens[1]));
                break;
            case "tune":
                this.Tune(int.Parse(tokens[1]), tokens[2]);
                break;
            default:
                throw new ArgumentException($"Invalid comand name");
        }
    }
}

