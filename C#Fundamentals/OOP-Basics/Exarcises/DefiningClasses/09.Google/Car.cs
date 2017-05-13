namespace _09.Google
{
    public class Car
    {
        public Car()
        {

        }

        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        public string Model { get; set; }
        public int Speed { get; set; }
    }
}
