using SoccerLeagueApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.sport_app
{
    public class Game
    {
        private Team teamA;
        private Team teamB;
        private int goalsTeamA;
        private int goalsTeamB;
        private int currentMinute;
        private bool isActive;
        private string gameEvents;

        public Game(Team teamA, Team teamB)
        {
            this.teamA = teamA;
            this.teamB = teamB;
        }

        public Team GetTeamA()
        {
            return teamA;
        }

        public void SetTeamA(Team teamA)
        {
            this.teamA = teamA;
        }

        public Team GetTeamB()
        {
            return teamB;
        }

        public void SetTeamB(Team teamB)
        {
            this.teamB = teamB;
        }

        public int GetGoalsTeamA()
        {
            return goalsTeamA;
        }

        public void SetGoalsTeamA(int goalsTeamA)
        {
            this.goalsTeamA = goalsTeamA;
        }

        public int GetGoalsTeamB()
        {
            return goalsTeamB;
        }

        public void SetGoalsTeamB(int goalsTeamB)
        {
            this.goalsTeamB = goalsTeamB;
        }

        public int GetCurrentMinute()
        {
            return currentMinute;
        }

        public void SetCurrentMinute(int currentMinute)
        {
            this.currentMinute = currentMinute;
        }

        public bool GetIsActive()
        {
            return isActive;
        }

        public void SetIsActive(bool isActive)
        {
            this.isActive = isActive;
        }

        public string GetGameEvents()
        {
            return gameEvents;
        }

        public void AddGameEvent(string eventDescription)
        {
            gameEvents += $"{currentMinute}' - {eventDescription}\n";
        }

        public override string ToString()
        {
            return $"Game between {teamA.GetName()} and {teamB.GetName()}";
        }
    }
}
