using c_sharp_apps_shay_shalom_izhak.sport_app;
using System;

namespace SoccerLeagueApp
{
    public class Season
    {
        private int year;
        private string sportType;
        private string leagueType;
        private int totalRounds;
        private Round nextRound;
        private Team[] teams;
        private int numberOfTeams;
        private bool isActive;
        private Team champion;

        public Season(int year, string sportType, string leagueType, int totalRounds, int numberOfTeams)
        {
            this.year = year;
            this.sportType = sportType;
            this.leagueType = leagueType;
            this.totalRounds = totalRounds;
            this.numberOfTeams = numberOfTeams;
            teams = new Team[numberOfTeams];
        }

        public int GetYear() => year;
        public void SetYear(int year) => this.year = year;

        public string GetSportType() => sportType;
        public void SetSportType(string sportType) => this.sportType = sportType;

        public string GetLeagueType() => leagueType;
        public void SetLeagueType(string leagueType) => this.leagueType = leagueType;

        public int GetTotalRounds() => totalRounds;
        public void SetTotalRounds(int totalRounds) => this.totalRounds = totalRounds;

        public Round GetNextRound() => nextRound;
        public void SetNextRound(Round nextRound) => this.nextRound = nextRound;

        public Team[] GetTeams() => teams;
        public void SetTeams(Team[] teams) => this.teams = teams;

        public int GetNumberOfTeams() => numberOfTeams;
        public void SetNumberOfTeams(int numberOfTeams) => this.numberOfTeams = numberOfTeams;

        public bool GetIsActive() => isActive;
        public void SetIsActive(bool isActive) => this.isActive = isActive;

        public Team GetChampion() => champion;
        public void SetChampion(Team champion) => this.champion = champion;

        public override string ToString() => $"{leagueType} ({year})";

        public void DisplayTable()
        {
            Console.WriteLine($"Table for {leagueType} Season {year}:");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|   Team Name         |   Wins   |   Losses   |   Draws   |   Points|");
            Console.WriteLine("-------------------------------------------------------------------");

            foreach (Team team in teams)
            {
                Console.WriteLine($"|   {team.GetName(),-16}   |   {team.GetWins(),-6}   |   {team.GetLosses(),-7}   |   {team.GetDraws(),-6}   |   {team.GetPoints(),-7}   |");
            }

            Console.WriteLine("-------------------------------------------------------------------");
        }
    }
}
