public class ArrayCreator
{
    public static T[] Create<T>(int length, T item)
    {
        return new T[length];
    }
}

