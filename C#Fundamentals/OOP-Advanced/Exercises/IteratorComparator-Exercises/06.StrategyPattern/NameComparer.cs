using System.Collections.Generic;

public class NameComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        var result = x.Name.Length.CompareTo(y.Name.Length);
        if (result == 0)
        {
            result = char.ToLower(x.Name[0]).CompareTo(char.ToLower(y.Name[0]));
        }

        return result;
    }
}

