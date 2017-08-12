using System;
using System.Linq;

public class Database : ICustomCollection
{
    private const int Capacity = 16;
    private const string CapacityExeptionMessage = "The max capacity of the collection is {Capacity}.";
    private const string EmptyCollectionExeptionMessage = "The collection is already empty.";

    private readonly int[] myList;
    private int currentIndex;

    public Database(params int[] inputNumbers)
    {
        this.myList = new int[Capacity];

        if (inputNumbers.Length > Capacity)
        {
            throw new InvalidOperationException(CapacityExeptionMessage);
        }

        foreach (int inputItem in inputNumbers)
        {
            this.myList[this.currentIndex] = inputItem;
            this.currentIndex++;
        }
    }

    public int Index => this.currentIndex;

    public void Add(int number)
    {
        if (this.currentIndex >= Capacity)
        {
            throw new InvalidOperationException(CapacityExeptionMessage);
        }

        myList[currentIndex] = number;
        this.currentIndex++;
    }


    public void Remove()
    {
        if (this.currentIndex == 0)
        {
            throw new InvalidOperationException(EmptyCollectionExeptionMessage);
        }

        this.myList[this.currentIndex - 1] = 0;
        this.currentIndex--;
    }

    public int[] Fetch()
    {
        return this.myList.Take(currentIndex).ToArray();
    }
}
