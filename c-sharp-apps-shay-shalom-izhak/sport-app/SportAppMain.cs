using c_sharp_apps_Akiva_Cohen.sport_app;
using c_sharp_apps_shay_shalom_izhak.common;
using SoccerLeagueApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.sport_app
{
    public class SportAppMain
    {
        public static void MainEntry()
        {
            BgColorForApp bgColorForApp = new BgColorForApp();
            bgColorForApp.ChangeBgColor();
            Console.WriteLine("\n welcom To SportApp!");
            Console.WriteLine();

            Team team1 = new Team("Team A", "City A", "League A");
            Team team2 = new Team("Team B", "City B", "League A");
            Team team3 = new Team("Team C", "City C", "League A");
            Team team4 = new Team("Team D", "City D", "League A");



            Season season2024 = new Season(2024, "Soccer", "National", 10, 4);

            
            Team[] teams = { team1, team2, team3, team4 };
            season2024.SetTeams(teams);

            
            Round nextRound = new Round(1, 10);
            season2024.SetNextRound(nextRound);

            
            team1.UpdateStatistics(5, 2, 30, 15, 10);
            team2.UpdateStatistics(4, 3, 3, 12, 12);
            team3.UpdateStatistics(6, 1, 3, 20, 8);
            team4.UpdateStatistics(3, 4, 3, 10, 15);

            
            Console.WriteLine($"Season Year: {season2024.GetYear()}");
            Console.WriteLine($"Sport Type: {season2024.GetSportType()}");
            Console.WriteLine($"League Type: {season2024.GetLeagueType()}");
            Console.WriteLine($"Total Rounds: {season2024.GetTotalRounds()}");
            Console.WriteLine($"Number of Teams: {season2024.GetNumberOfTeams()}");
            Console.WriteLine($"Is Active: {season2024.GetIsActive()}");
            Console.WriteLine($"Champion: {season2024.GetChampion()}");

            
            season2024.DisplayTable();

            
            Console.WriteLine($"\nNext Round: {season2024.GetNextRound()}");

            
            Team winner = DetermineWinner(season2024.GetTeams());
            Console.WriteLine($"\nThe winner is: {winner.GetName()}");

            Console.WriteLine();
            TestSportApp.Test1();

            Console.WriteLine("\n type anything to exit!");
            Console.ReadLine();
        }

        static Team DetermineWinner(Team[] teams)
        {
            Team winner = null;
            int maxPoints = int.MinValue;

            foreach (Team team in teams)
            {
                if (team.GetPoints() > maxPoints)
                {
                    maxPoints = team.GetPoints();
                    winner = team;
                }
            }

            return winner;
        }
    }
}
