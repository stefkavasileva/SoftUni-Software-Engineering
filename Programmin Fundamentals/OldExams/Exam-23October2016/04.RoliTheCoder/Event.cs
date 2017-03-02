namespace _04.RoliTheCoder
{
    using System.Collections.Generic;

    public class Event
    {
        public Event(string name, string id, SortedSet<string> participants)
        {
            this.Name = name;
            this.Id = id;
            this.Participants = participants;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public SortedSet<string> Participants { get; set; }
    }
}
