using System.Collections.Generic;

namespace _02.UniqueStudentNames
{
    public class StudentGroup
    {
        static StudentGroup()
        {
            uniqueStudentNames = new HashSet<string>();
        }

        public static HashSet<string> uniqueStudentNames;
    }
}
