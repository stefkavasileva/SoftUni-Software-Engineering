using System.Collections.Generic;
using System.Linq;

public class Box<T>
{
    private IList<T> myList;

    public Box()
    {
        this.myList = new List<T>();
    }

    public void Add(T element)
    {
        this.myList.Add(element);
    }

    public T Remove()
    {
        var lastElement = this.myList.LastOrDefault();
        this.myList.RemoveAt(this.myList.Count - 1);
        return lastElement;
    }

    public int Count => this.myList.Count;
}

