using System.Collections.Generic;

namespace _07.ImmutableList
{
    public class ImmutableList
    {
        public List<int> numbers;

        public ImmutableList GetNewList()
        {
            return new ImmutableList();
        }
    }
}
