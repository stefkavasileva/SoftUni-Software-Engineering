using System.Collections.Generic;

public class CasualRace : Race
{
    public CasualRace(int length, string route, int prizePool)
        : base(length, route, prizePool)
    {

    }

    public override double GetPoint(Car car)
    {
        return (car.Horsepower / car.Acceleration) + car.Suspension + car.Durability;
    }
}

