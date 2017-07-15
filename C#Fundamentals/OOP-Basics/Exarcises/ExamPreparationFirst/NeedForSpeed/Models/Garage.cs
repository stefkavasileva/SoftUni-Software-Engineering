using System.Collections.Generic;

public class Garage
{
    public List<Car> ParkedCars { get; set; }

    public Garage(List<Car> parkedCars)
    {
        this.ParkedCars = parkedCars;
    }
}

