using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }

        public int Count => roster.Count;

        public string Name { get; set; }

        public int Capacity { get; set; }

        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player player = roster.FirstOrDefault(x => x.Name == name);
            return roster.Remove(player);
        }

        public void PromotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(x => x.Name == name);
            int index = 0;
            index = roster.IndexOf(player);
            if (player.Rank != "Member")
            {
                player.Rank = "Member";
                roster[index] = player;
            }

        }

        public void DemotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(x => x.Name == name);
            int index = 0;
            index = roster.IndexOf(player);
            if (player.Rank != "Trial")
            {
                player.Rank = "Trial";
                roster[index] = player;
            }
        }
        public Player[] KickPlayersByClass(string @class)

        {
            List<Player> kickList = roster.Where(x => x.Class == @class).ToList();
            Player[] array = new Player[kickList.Count];
            for (int i = 0; i < kickList.Count; i++)
            {
                array[i] = kickList[i];
                roster.Remove(kickList[i]);
            }

            return array;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var player in roster)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
