using System.Collections.Generic;

public class DriftRace : Race
{
    public DriftRace(int length, string route, int prizePool)
        : base(length, route, prizePool)
    {
    }

    public override double GetPoint(Car car)
    {
        return (car.Suspension + car.Durability);
    }
}

