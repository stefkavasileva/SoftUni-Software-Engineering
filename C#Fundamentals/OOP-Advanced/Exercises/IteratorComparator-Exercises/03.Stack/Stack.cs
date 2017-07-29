using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Stack<T> : IEnumerable<T>
{
    private IList<T> customStack;

    public Stack()
    {
        this.customStack = new List<T>();
    }

    public void Push(T item)
    {
        this.customStack.Insert(0, item);
    }

    public T Pop()
    {
        if (!this.customStack.Any())
        {
            throw new ArgumentException("No elements");
        }

        var popedItem = customStack.First();
        customStack.RemoveAt(0);
        return popedItem;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this.customStack.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

