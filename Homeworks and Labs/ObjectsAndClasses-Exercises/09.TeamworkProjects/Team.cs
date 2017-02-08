namespace _09.TeamworkProjects
{
    using System.Collections.Generic;

    public class Team
    {
        public Team(string name, string creator, List<string> members)
        {
            this.Name = name;
            this.Creator = creator;
            this.Members = members;
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
}
