using System;
public class Scale<T>
    where T : IComparable<T>
{
    private T first;
    private T second;

    public Scale(T first, T second)
    {
        this.first = first;
        this.second = second;
    }

    public T GetHavier()
    {
        var result = this.first.CompareTo(this.second);

        if (result == 0)
        {
            return default(T);


        }

        return result > 0 ? this.first : this.second;
    }
}