using c_sharp_apps_shay_shalom_izhak.common;
using SoccerLeagueApp;
using System;

namespace c_sharp_apps_shay_shalom_izhak.sport_app
{
    
     public class SportAppMain
     {
        private static Season[] groups;

        public static void MainEntry()
        {
            BgColorForApp bgColorForApp = new BgColorForApp();
            bgColorForApp.ChangeBgAndFontColor();
            Console.WriteLine("\nWelcome To SportApp!");
            Console.WriteLine();

            groups = TestSportApp.CreateChampionsLeagueMock();

            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Play a Game");
                Console.WriteLine("2. Show League Table");
                Console.WriteLine("3. Change Colors");
                Console.WriteLine("4. Run GeneralPlayer Class");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PlayGame();
                        break;
                    case "2":
                        ShowLeagueTable();
                        break;
                    case "3":
                        bgColorForApp.ChangeBgAndFontColor();
                        break;
                    case "4":
                        RunGeneralPlayer.RunMain();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void PlayGame()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose a league to play a game:");
                for (int i = 0; i < groups.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {groups[i]}");
                }
                Console.Write("Enter league number: ");
                if (int.TryParse(Console.ReadLine(), out int leagueIndex) && leagueIndex > 0 && leagueIndex <= groups.Length)
                {
                    leagueIndex--; // Convert to zero-based index
                    Season selectedSeason = groups[leagueIndex];
                    Team[] teams = selectedSeason.GetTeams();

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Choose two teams to play a game:");
                        for (int i = 0; i < teams.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {teams[i].GetName()}");
                        }
                        Console.Write("Enter first team number: ");
                        if (int.TryParse(Console.ReadLine(), out int team1Index) && team1Index > 0 && team1Index <= teams.Length)
                        {
                            team1Index--; // Convert to zero-based index
                            Console.Write("Enter second team number: ");
                            if (int.TryParse(Console.ReadLine(), out int team2Index) && team2Index > 0 && team2Index <= teams.Length && team2Index != team1Index)
                            {
                                team2Index--; // Convert to zero-based index
                                Team team1 = teams[team1Index];
                                Team team2 = teams[team2Index];
                                Random rand = new Random();
                                int goalsTeam1 = rand.Next(0, 5);
                                int goalsTeam2 = rand.Next(0, 5);

                                Game game = new Game(team1, team2);
                                game.SetGoalsTeamA(goalsTeam1);
                                game.SetGoalsTeamB(goalsTeam2);
                                game.FinishGame();

                                Console.WriteLine($"\n{team1.GetName()} {goalsTeam1} - {goalsTeam2} {team2.GetName()}");
                                Console.WriteLine("Game finished. Press any key to return to the menu.");
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid team selection. Press any key to try again.");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid team selection. Press any key to try again.");
                            Console.ReadKey();
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid league selection. Press any key to try again.");
                    Console.ReadKey();
                }
            }
        }

        private static void ShowLeagueTable()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose a league to show the table:");
                for (int i = 0; i < groups.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {groups[i]}");
                }
                Console.Write("Enter league number: ");
                if (int.TryParse(Console.ReadLine(), out int leagueIndex) && leagueIndex > 0 && leagueIndex <= groups.Length)
                {
                    leagueIndex--; // Convert to zero-based index
                    Console.Clear();
                    Season selectedSeason = groups[leagueIndex];
                    selectedSeason.DisplayTable();
                    Console.WriteLine("\nPress any key to return to the menu.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid league selection. Press any key to try again.");
                    Console.ReadKey();
                }
            }
        }
    }
}
