using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Team_Generator.Data
{
    public class FantasyOperation
    {
        public List<string> GetTeam()
        {
            List<string> team= new List<string>();
            string playerName;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Enter {i+1} Name of player");
                playerName= Console.ReadLine()!;
                team.Add(playerName);
            }

            return team;
        }

        public List<string> GetFantasyTeam()
        {
            List<string> fantasyTeam = new List<string>();

            return fantasyTeam;

        }
    }
}
