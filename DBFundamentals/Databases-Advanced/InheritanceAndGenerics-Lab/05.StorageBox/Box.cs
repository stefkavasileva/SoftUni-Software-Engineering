using System;
using System.Text;

public class Box<T>
{
    private T[] data;
    private int count;

    public Box()
    {
        this.data = new T[4];
        this.Count = 0;
    }

    public int Count
    {
        get => this.count;
        private set
        {
            if (value > data.Length)
            {
                throw  new IndexOutOfRangeException("Collection is full.");
            }

            this.count = value;
        }
    }

    public void Add(T item)
    {
        if (this.Count == data.Length)
        {
            T[] oldData = data;
            data = new T[this.Count * 2];
            oldData.CopyTo(data,0);
        }

        this.data[this.Count] = item;
        this.Count++;
    }

    public T Remove()
    {
        var lastIndex = this.Count - 1;
        var item = data[lastIndex];
        data[lastIndex] = default(T);
        this.Count--;
        return item;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < this.Count; i++)
        {
            sb.Append(this.data[i].ToString());
            if (i > this.Count - 1)
            {
                sb.Append(", ");
            }
        }

        return sb.ToString();
    }
}

