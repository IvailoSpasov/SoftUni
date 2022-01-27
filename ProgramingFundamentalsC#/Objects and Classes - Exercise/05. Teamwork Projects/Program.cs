using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("-");
                if (teams.Any(team => team.TeamName == input[1]))
                {
                    Console.WriteLine($"Team {input[1]} was already created!");
                }
                else if (teams.Any(creator => creator.Creator == input[0]))
                {
                    Console.WriteLine($"{input[0]} cannot create another team!");
                }
                else
                {
                    Team team = new Team();
                    team.Creator = input[0];
                    team.TeamName = input[1];
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
                }
            }

            string[] cmd = Console.ReadLine().Split("->");
            while (cmd[0] != "end of assignment")
            {
                string member = cmd[0];
                string team = cmd[1];
                if (!teams.Any(team1 => team1.TeamName == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (teams.Any(team1 => team1.Members.Contains(member))||teams.Any(team1=>team1.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                }
                else
                {
                    Team currTeam = teams.First(t => t.TeamName == team);
                    currTeam.Members.Add(member);
                }
                cmd = Console.ReadLine().Split("->");
            }

            var orderedList = teams.Where(team => team.Members.Count > 0);
            var disbanded = teams.Where(team => team.Members.Count == 0);
            foreach (Team team in orderedList.OrderByDescending(team => team.Members.Count).ThenBy(team => team.TeamName))
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            if (disbanded!= null)
            {
                foreach (Team team in disbanded.OrderBy(team => team.TeamName))
                {
                    Console.WriteLine(team.TeamName);
                }
            }
        }
    }
}
