using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Box<T>
    where T : IComparable<T>
{
    private IList<T> data;

    public Box()
    {
        this.data = new List<T>();
    }

    public IList<T> Data => this.data;

    public void Add(T element)
    {
        this.data.Add(element);
    }

    public void Swap(int firstIndex, int secondIndex)
    {
        var firstElement = this.data[firstIndex];
        data[firstIndex] = data[secondIndex];
        data[secondIndex] = firstElement;
    }

    public int Compare(IList<T> elements, T someElement)
    {
        var counter = 0;
        foreach (var element in elements)
        {
            if (someElement.CompareTo(element) < 0)
            {
                counter++;
            }
        }

        return counter;
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var element in this.data)
        {
            sb.AppendLine($"{element.GetType().FullName}: {element}");
        }

        return sb.ToString().Trim();
    }
}

