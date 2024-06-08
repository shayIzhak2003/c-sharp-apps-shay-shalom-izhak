using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.sport_app
{
    public class Team
    {
        private string name;
        private string city;
        private string currentLeague;
        private int totalGames;
        private int gamesPlayed;
        private int wins;
        private int losses;
        private int draws;
        private int points;
        private int goalsFor;
        private int goalsAgainst;
        private string homeStadium;
        private decimal budget;

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetCity()
        {
            return this.city;
        }

        public void SetCity(string city)
        {
            this.city = city;
        }

        public string GetCurrentLeague()
        {
            return this.currentLeague;
        }

        public void SetCurrentLeague(string currentLeague)
        {
            this.currentLeague = currentLeague;
        }

        public int GetTotalGames()
        {
            return this.totalGames;
        }

        public void SetTotalGames(int totalGames)
        {
            this.totalGames = totalGames;
        }

        public int GetPoints()
        {
            return this.points;
        }

        public void SetPoints(int points)
        {
            this.points = points;
        }

        public int GetGoalsFor()
        {
            return this.goalsFor;
        }

        public void SetGoalsFor(int goalsFor)
        {
            this.goalsFor = goalsFor;
        }

        public int GetGoalsAgainst()
        {
            return this.goalsAgainst;
        }

        public void SetGoalsAgainst(int goalsAgainst)
        {
            this.goalsAgainst = goalsAgainst;
        }

        public Team(string name, string city, string currentLeague)
        {
            this.name = name;
            this.city = city;
            this.currentLeague = currentLeague;
        }

        public void UpdateStatistics(int wins, int losses, int draws, int goalsFor, int goalsAgainst)
        {
            this.wins += wins;
            this.losses += losses;
            this.draws += draws;
            this.goalsFor += goalsFor;
            this.goalsAgainst += goalsAgainst;
            this.points = (this.wins * 3) + this.draws;
            this.gamesPlayed += (wins + losses + draws);
            this.totalGames = this.gamesPlayed;
        }

        public override string ToString()
        {
            return $"Team[name={name}, city={city}, currentLeague={currentLeague}, points={points}]";
        }
    }
}
