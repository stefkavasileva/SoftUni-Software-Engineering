namespace _02.SoftUniKaraoke
{
    using System.Collections.Generic;

    public class Participant
    {
        public Participant(string name, HashSet<string> awards)
        {
            this.Name = name;
            this.Awards = awards;
        }

        public string Name { get; set; }

        public HashSet<string> Awards { get; set; }
    }
}
