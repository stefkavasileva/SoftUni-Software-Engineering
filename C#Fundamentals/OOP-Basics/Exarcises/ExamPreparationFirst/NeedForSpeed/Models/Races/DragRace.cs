using System.Collections.Generic;

public class DragRace : Race
{
    public DragRace(int length, string route, int prizePool) 
        : base(length, route, prizePool)
    {
    }

    public override double GetPoint(Car car)
    {
        return (car.Horsepower / car.Acceleration);
    }
}

