using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Team
{
    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }
}

class TeamworkProjects
{
    static void Main(string[] args)
    {
        List<Team> teams = new List<Team>();
        List<string> messages = new List<string>();

        int teamsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < teamsCount; i++)
        {
            string[] teamArgs = Console.ReadLine()
                .Split('-').ToArray();

            string teamName = teamArgs[1];
            string teamCreator = teamArgs[0];

            if (teams.Exists(x => x.Name == teamName))
            {
                messages.Add($"Team {teamName} was already created!");
                continue;
            }

            if (teams.Exists(x => x.Creator == teamCreator))
            {
                messages.Add($"{teamCreator} cannot create another team!");
                continue;
            }

            Team team = new Team();
            team.Name = teamName;
            team.Creator = teamCreator;
            team.Members = new List<string>();

            teams.Add(team);
            messages.Add($"Team {teamName} has been created by {teamCreator}!");

        }

        string membersToAdd = Console.ReadLine();

        while (!membersToAdd.Equals("end of assignment"))
        {
            string[] membersArgs = membersToAdd
                .Split('-').ToArray();

            string memberName = membersArgs[0];
            string teamName = membersArgs[1].Substring(1);

            if (!teams.Exists(x => x.Name == teamName))
            {
                messages.Add($"Team {teamName} does not exist!");
                membersToAdd = Console.ReadLine();
                continue;
            }

            if (teams.Exists(x => x.Creator == memberName) || teams.Select(x => x.Members).Any(x => x.Contains(memberName)))
            {
                messages.Add($"Member {memberName} cannot join team {teamName}!");
                membersToAdd = Console.ReadLine();
                continue;
            }

            for (int i = 0; i < teams.Count; i++)
            {
                Team currentTeam = teams[i];
                AddMembersToTeam(memberName, teamName, currentTeam);
            }

            membersToAdd = Console.ReadLine();
        }

        PrintMessages(messages);

        List<Team> disbandTeams = teams
            .OrderBy(x => x.Name)
            .Where(x => x.Members.Count() == 0)
            .ToList();

        teams = teams
            .OrderByDescending(x => x.Members.Count())
            .ThenBy(x => x.Name)
            .Where(x=>x.Members.Count>0)
            .ToList();

        foreach (var team in teams)
        {
            List<string> members = team.Members.OrderBy(x=>x).ToList();
            if (members.Count == 0)
            {
                disbandTeams.Add(team);
                continue;
            }

            Console.WriteLine(team.Name);
            Console.WriteLine($"- {team.Creator}");

            PrintMembersInTeam(members);
        }

        PrintDisbandTeams(disbandTeams);

    }

    private static void AddMembersToTeam(string memberName, string teamName, Team currentTeam)
    {
        if (currentTeam.Name == teamName)
        {
            if (currentTeam.Members == null)
            {
                currentTeam.Members = new List<string>();
            }

            currentTeam.Members.Add(memberName);
        }
    }

    private static void PrintMessages(List<string> messages)
    {
        foreach (var message in messages)
        {
            Console.WriteLine(message);
        }
    }

    private static void PrintMembersInTeam(List<string> members)
    {
        for (int i = 0; i < members.Count; i++)
        {
            Console.WriteLine($"-- {members[i]}");
        }
    }

    private static void PrintDisbandTeams(List<Team> disbandTeams)
    {
        Console.WriteLine("Teams to disband:");

        foreach (var disbandTeam in disbandTeams)
        {
            Console.WriteLine(disbandTeam.Name);
        }
    }
}

