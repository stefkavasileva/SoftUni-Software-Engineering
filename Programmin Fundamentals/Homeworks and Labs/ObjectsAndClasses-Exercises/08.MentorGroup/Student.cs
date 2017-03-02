namespace _08.MentorGroup
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public Student(string name, List<string> comments, List<DateTime> datesActivities)
        {
            this.Name = name;
            this.Comments = comments;
            this.DatesActivities = datesActivities;
        }

        public string Name { get; set; }

        public List<string> Comments { get; set; }

        public List<DateTime> DatesActivities { get; set; }
    }
}
