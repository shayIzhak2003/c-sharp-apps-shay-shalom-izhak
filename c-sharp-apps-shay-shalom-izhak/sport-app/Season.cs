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

        public int GetYear()
        {
            return year;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }

        public string GetSportType()
        {
            return sportType;
        }

        public void SetSportType(string sportType)
        {
            this.sportType = sportType;
        }

        public string GetLeagueType()
        {
            return leagueType;
        }

        public void SetLeagueType(string leagueType)
        {
            this.leagueType = leagueType;
        }

        public int GetTotalRounds()
        {
            return totalRounds;
        }

        public void SetTotalRounds(int totalRounds)
        {
            this.totalRounds = totalRounds;
        }

        public Round GetNextRound()
        {
            return nextRound;
        }

        public void SetNextRound(Round nextRound)
        {
            this.nextRound = nextRound;
        }

        public Team[] GetTeams()
        {
            return teams;
        }

        public void SetTeams(Team[] teams)
        {
            this.teams = teams;
        }

        public int GetNumberOfTeams()
        {
            return numberOfTeams;
        }

        public void SetNumberOfTeams(int numberOfTeams)
        {
            this.numberOfTeams = numberOfTeams;
        }

        public bool GetIsActive()
        {
            return isActive;
        }

        public void SetIsActive(bool isActive)
        {
            this.isActive = isActive;
        }

        public Team GetChampion()
        {
            return champion;
        }

        public void SetChampion(Team champion)
        {
            this.champion = champion;
        }

        public override string ToString()
        {
            return $"Season {year} - {leagueType}";
        }

        public void DisplayTable()
        {
            Console.WriteLine($"Table for {leagueType} Season {year}:");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("|   Team Name   |   City   |   Points   |   Goals For   |   Goals Against   |");
            Console.WriteLine("---------------------------------------------------------");

            foreach (Team team in teams)
            {
                Console.WriteLine($"|   {team.GetName(),-13}   |   {team.GetCity(),-8}   |   {team.GetPoints(),-9}   |   {team.GetGoalsFor(),-12}   |   {team.GetGoalsAgainst()-16}   |");
            }

            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
