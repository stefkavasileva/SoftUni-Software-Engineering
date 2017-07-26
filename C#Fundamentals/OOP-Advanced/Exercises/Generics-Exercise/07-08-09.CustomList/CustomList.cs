using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CustomList<T>
    : ICustomList<T>,IEnumerable<T> where T
    : IComparable<T>
{
    private const int Initialcapacity = 16;
    private T[] data;
    private int length;

    private IEnumerable<T> myList;

    public CustomList()
    {
        data = new T[Initialcapacity];
        this.myList = new List<T>();
    }

    public IEnumerable<T> Data => this.myList;

    public void Add(T element)
    {
        if (this.length == this.data.Length)
        {
            this.data = this.data.Concat(new T[this.length]).ToArray();
        }

        this.data[this.length] = element;
        this.length++;
    }

    public T Remove(int index)
    {
        var element = this.data[index];
        this.data = this.data.Take(index).Concat(this.data.Skip(index + 1)).ToArray();
        this.length--;
        return element;
    }

    public bool Contains(T element)
    {
        if (this.length == 0)
        {
            return false;
        }

        var comparer = EqualityComparer<T>.Default;

        foreach (var item in this.data)
        {
            if (comparer.Equals(item, element))
            {
                return true;
            }
        }

        return false;
    }

    public void Swap(int index1, int index2)
    {
        var temp = this.data[index1];
        this.data[index1] = this.data[index2];
        this.data[index2] = temp;
    }

    public int CountGreaterThan(T element)
    {
        var counter = 0;
        foreach (var currentElement in this.data)
        {
            if (element.CompareTo(currentElement) < 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public T Max()
    {
        return this.data.Max();
    }

    public T Min()
    {
        return this.data.Min();
    }


    public IEnumerable<T> MyList { get; }

    public void Sort()
    {
       this.data = this.data
            .Take(this.length)
            .OrderBy(x => x)
            .Concat(new T[this.data.Length - this.length])
            .ToArray();
    }


    public IEnumerator<T> GetEnumerator()
    {
        return this.data.Take(this.length).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.data.Take(this.length).GetEnumerator();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var element in this.Data)
        {
            sb.AppendLine(element.ToString());
        }

        return sb.ToString().Trim();
    }
}

