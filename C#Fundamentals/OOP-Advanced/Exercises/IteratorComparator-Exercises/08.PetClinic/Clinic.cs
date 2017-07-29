using System.Collections;
using System.Collections.Generic;

public class Clinic : IEnumerable
{
    public List<Pet> RoomsWithPet { get; set; }

    public Clinic()
    {
        this.RoomsWithPet = new List<Pet>();
    }

    public IEnumerator GetEnumerator()
    {
        var currentIndex = this.RoomsWithPet.Count / 2;
        while (currentIndex > 0 && currentIndex < this.RoomsWithPet.Count)
        {
            yield return this.RoomsWithPet[currentIndex];
            
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

