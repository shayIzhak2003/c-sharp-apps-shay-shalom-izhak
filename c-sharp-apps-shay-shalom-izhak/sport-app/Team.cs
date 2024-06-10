using System;

namespace c_sharp_apps_shay_shalom_izhak.sport_app
{
    public class Team
    {
        private string name;
        private string city;
        private int points;
        private int wins;
        private int losses;
        private int draws;
        private int goalsFor;
        private int goalsAgainst;

        public Team(string name, string city)
        {
            this.name = name;
            this.city = city;
        }

        public string GetName() => name;
        public void SetName(string name) => this.name = name;

        public string GetCity() => city;
        public void SetCity(string city) => this.city = city;

        public int GetPoints() => points;
        public void SetPoints(int points) => this.points = points;

        public int GetWins() => wins;
        public void SetWins(int wins) => this.wins = wins;

        public int GetLosses() => losses;
        public void SetLosses(int losses) => this.losses = losses;

        public int GetDraws() => draws;
        public void SetDraws(int draws) => this.draws = draws;

        public int GetGoalsFor() => goalsFor;
        public void SetGoalsFor(int goalsFor) => this.goalsFor = goalsFor;

        public int GetGoalsAgainst() => goalsAgainst;
        public void SetGoalsAgainst(int goalsAgainst) => this.goalsAgainst = goalsAgainst;

        public void UpdateStatistics(int wins, int losses, int draws, int goalsFor, int goalsAgainst)
        {
            this.wins += wins;
            this.losses += losses;
            this.draws += draws;
            this.goalsFor += goalsFor;
            this.goalsAgainst += goalsAgainst;
            this.points += wins * 3 + draws;
        }

        public override string ToString() => $"{name} ({city})";
    }
}
