using System;

namespace BashSoft.Exceptions
{
    public class DuplicateEntryInStructureException : Exception
    {
        public const string DuplicateEntry = "The {0} already exists in {1}";

        public DuplicateEntryInStructureException(string message)
            : base(message)
        {

        }

        public DuplicateEntryInStructureException(string entry, string structure)
            : base(string.Format(DuplicateEntry, entry, structure))
        {

        }
    }
}
