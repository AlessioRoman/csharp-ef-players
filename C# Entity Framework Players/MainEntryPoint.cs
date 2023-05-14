using EntityFramework;

class MainEntryPoint
{
    static void Main()
    {
        bool quit = false;
        do
        {
            Console.WriteLine("Che operazione vuoi eseguire?");
            Console.WriteLine("[1] Aggiungi un team");
            Console.WriteLine("[2] Aggiungi un giocatore");
            Console.WriteLine("[3] Ricerca un giocatore");
            Console.WriteLine("[4] Termina il programma");
            int selector = Convert.ToInt16(Console.ReadLine());

            switch (selector)
            {
                case 1:
                    string[] teamInfo = Utility.GetTeamInfo();
                    try
                    {
                        using (SportContext db = new())
                        {
                            Team newTeam = new(teamInfo[0], teamInfo[2], teamInfo[2], teamInfo[3]);
                            db.Add(newTeam);
                            db.SaveChanges();
                        }
                    } catch (Exception e)
                    {
                        Console.WriteLine(e.Message + "\n" + e.StackTrace);
                    }
                    break;
                case 2:
                    string[] playerInfo = Utility.GetPlayerInfo();
                    try
                    {
                        using (SportContext db = new())
                        {
                            Player newPlayer = new(playerInfo[0], playerInfo[1]);
                            Console.WriteLine("Il giocatore è sotto contratto in un team? \n[1] Si \n[2] No");
                            int isInTeam = Convert.ToInt16(Console.ReadLine());
                            if (isInTeam == 1)
                            {
                                newPlayer.TeamId = Utility.GetPlayerTeam();
                                Team playerTeam = db.Teams.Where(Team => Team.TeamId == newPlayer.TeamId).First();
                                newPlayer.ChangeTeam(playerTeam);
                                playerTeam.AddPlayer(newPlayer);
                                
                            }
                            db.Add(newPlayer);
                            db.SaveChanges();
                        }
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message + "\n" + e.StackTrace);
                    }
                    break;
                case 3:
                    using (SportContext db = new())
                    {
                        Player playerResearch = db.Players.Where(Player => Player.Name == "Kvara").First();
                        Console.WriteLine(playerResearch.ToString());
                    }
                    break;
                case 4:
                    quit = true;
                    break;
                default: 
                    Console.WriteLine("Operazione non valida!");
                    break;
            }

        } while (!quit);
    }
}