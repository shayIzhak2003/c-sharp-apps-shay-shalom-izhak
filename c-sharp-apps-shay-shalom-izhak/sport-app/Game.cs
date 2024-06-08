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
            this.goalsTeamA = 0;
            this.goalsTeamB = 0;
            this.currentMinute = 0;
            this.isActive = true;
            this.gameEvents = string.Empty;
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

        public void ScoreGoal(Team scoringTeam)
        {
            if (scoringTeam == teamA)
            {
                goalsTeamA++;
                AddGameEvent($"{teamA.GetName()} scored! Total: {goalsTeamA} goals.");
            }
            else if (scoringTeam == teamB)
            {
                goalsTeamB++;
                AddGameEvent($"{teamB.GetName()} scored! Total: {goalsTeamB} goals.");
            }
            else
            {
                throw new ArgumentException("The scoring team is not part of this game.");
            }

            // Update the team's goals for and against
            scoringTeam.SetGoalsFor(scoringTeam.GetGoalsFor() + 1);
            if (scoringTeam == teamA)
            {
                teamB.SetGoalsAgainst(teamB.GetGoalsAgainst() + 1);
            }
            else
            {
                teamA.SetGoalsAgainst(teamA.GetGoalsAgainst() + 1);
            }
        }

        public void FinishGame()
        {
            isActive = false;

            // Update team statistics for wins, losses, and draws
            if (goalsTeamA > goalsTeamB)
            {
                teamA.UpdateStatistics(1, 0, 0, 0, 0); // Team A wins
                teamB.UpdateStatistics(0, 1, 0, 0, 0); // Team B loses
                AddGameEvent($"{teamA.GetName()} wins the game!");
            }
            else if (goalsTeamB > goalsTeamA)
            {
                teamA.UpdateStatistics(0, 1, 0, 0, 0); // Team A loses
                teamB.UpdateStatistics(1, 0, 0, 0, 0); // Team B wins
                AddGameEvent($"{teamB.GetName()} wins the game!");
            }
            else
            {
                teamA.UpdateStatistics(0, 0, 1, 0, 0); // Draw
                teamB.UpdateStatistics(0, 0, 1, 0, 0); // Draw
                AddGameEvent("The game ended in a draw.");
            }

            // Print final score and events
            Console.WriteLine($"Game between {teamA.GetName()} and {teamB.GetName()} has finished.");
            Console.WriteLine($"Final Score: {teamA.GetName()} {goalsTeamA} - {goalsTeamB} {teamB.GetName()}");
            Console.WriteLine("Game Events:\n" + gameEvents);
        }

        public override string ToString()
        {
            return $"Game between {teamA.GetName()} and {teamB.GetName()}";
        }
    }
}
