using System;

namespace _08.Car
{
    public class Car
    {
        public Car(double speed, double fuel, double fuelEconomy)
        {
            this.Speed = speed;
            this.Fuel = fuel;
            this.FuelEconomy = fuelEconomy;
        }

        public double Speed { get; set; }
        public double Fuel { get; set; }
        public double FuelEconomy { get; set; }
        public double TravelDistance { get; set; }
        public double TravelTime { get; set; }

        public void Travel(double distance)
        {
            var requiredFuel = this.FuelEconomy * (distance / 100);
            if (this.Fuel >= requiredFuel)
            {
                this.Fuel -= requiredFuel;
                this.TravelDistance += distance;
                this.TravelTime += (distance / this.Speed) * 60;
            }
            else
            {
                var passedDistance = this.Fuel / (this.FuelEconomy / 100);
                this.Fuel = 0;
                this.TravelDistance += passedDistance;
                this.TravelTime += (passedDistance / this.Speed) * 60;
            }
        }

        public void Refuel(double load)
        {
            this.Fuel += load;
        }

        public void Distance()
        {
            Console.WriteLine("Total distance: {0:F1} kilometers", this.TravelDistance);
        }

        public void Time()
        {
            Console.WriteLine("Total time: {0} hours and {1} minutes", this.TravelTime / 60, this.TravelTime % 60);
        }

        public void GetFuel()
        {
            Console.WriteLine("Fuel left: {0:F1} liters", this.Fuel);
        }
    }
}
