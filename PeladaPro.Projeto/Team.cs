using System;
using System.Collections.Generic;

namespace PeladaPro.Projeto
{
    public class Team
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }

        public Team(string name)
        {
            this.Name = name;
            this.Players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void PromotePlayer(CasualPlayer casual, decimal monthlyFee)
        {
            var promoted = MonthlyPlayer.PromoteFromCasual(casual, monthlyFee);
            Players.Remove(casual);
            Players.Add(promoted);
        }
    }
}
