namespace _05.AnimalClinic
{
    public class Animal
    {
        public Animal(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
            AnimalClinic.patientId++;
        }

        public string name;
        public string breed;
        public string state;

        public override string ToString()
        {
            return $"Patient {AnimalClinic.patientId}: [{this.name} ({this.breed})] has been {this.state}!";
        }
    }
}
