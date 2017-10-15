using System;

namespace BashSoft.Exceptions
{
    class DublicateEntryInStructureException : Exception
    {
        private const string DublicateEntry = "The {0} already exists in {1}.";

        public DublicateEntryInStructureException(string message)
            : base(message)
        {
        }

        public DublicateEntryInStructureException(string entry, string structure)
            : base(string.Format(DublicateEntry, entry, structure))
        {
        }
    }
}
