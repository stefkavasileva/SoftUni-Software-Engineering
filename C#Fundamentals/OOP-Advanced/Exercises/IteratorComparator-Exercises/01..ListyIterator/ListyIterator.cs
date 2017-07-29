using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ListyIterator<T> : IEnumerable<T>
{
    private IList<T> myCollection;
    private int currentIndex;

    public ListyIterator()
    {
        this.myCollection = new List<T>();
        this.currentIndex = 0;
    }

    public void Create(List<T> items)
    {
        if (items.Count.Equals(0))
        {
            throw new ArgumentException("Invalid Operation!");
        }

        items.ForEach(x => myCollection.Add(x));
    }

    public bool Move()
    {
        if (HasNext())
        {
            this.currentIndex++;
            return true;
        }

        return false;
    }

    public void Print()
    {
        if (this.myCollection.Any())
        {
            Console.WriteLine(this.myCollection[currentIndex]);
        }
    }

    public bool HasNext()
    {
        return this.currentIndex + 1 < this.myCollection.Count;
    }

    public string PrintAll()
    {
        if (!this.myCollection.Any())
        {
            throw new ArgumentException("Invalid Operation!");
        }

        var result = new StringBuilder();
        foreach (var item in this.myCollection)
        {
            result.Append($"{item} ");
        }

        return result.ToString().Trim();
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.myCollection.Count; i++)
        {
            yield return this.myCollection[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

