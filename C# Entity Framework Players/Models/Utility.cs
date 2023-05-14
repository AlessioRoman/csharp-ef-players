using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    static public class Utility
    {

        // GENERATOR
        public static int GenerateScore()
        {
            Random random = new();
            return random.Next(1, 10);
        }

        public static int GenerateMatches()
        {
            Random random = new();
            return random.Next(1, 100);
        }

        public static int GenerateWins(int numberOfMatches)
        {
            Random random = new();
            return random.Next(1, numberOfMatches);
        }

        //INFO EXTRACTOR
        public static string[] GetTeamInfo()
        {
            string[] teamInfo = new string[4];
            Console.WriteLine("Nome del team: ");
            teamInfo[0] = Console.ReadLine();
            Console.WriteLine("Città del team: ");
            teamInfo[1] = Console.ReadLine();
            Console.WriteLine("Coach del team: ");
            teamInfo[2] = Console.ReadLine();
            Console.WriteLine("Colori del team: ");
            teamInfo[3] = Console.ReadLine();

            return teamInfo;
        }

        public static string[] GetPlayerInfo()
        {
            string[] playerInfo = new string[2];
            Console.WriteLine("Nome del giocatore: ");
            playerInfo[0] = (Console.ReadLine());
            Console.WriteLine("Cognome del giocatore: ");
            playerInfo[1] = (Console.ReadLine());

            return playerInfo;
        }

        public static int GetPlayerTeam()
        {
            Console.WriteLine("Inserisci il nome del team: ");
            string teamName = Console.ReadLine();
            return GetTeamIndex(teamName);
        }

        public static int GetTeamIndex(string teamName)
        {
            int teamIndex;
            using (SportContext db = new())
            {
                Team playerTeam = db.Teams.Where(Team => Team.Name == teamName).First();
                teamIndex = playerTeam.TeamId;
            }

            return teamIndex;
        }
    }
}
