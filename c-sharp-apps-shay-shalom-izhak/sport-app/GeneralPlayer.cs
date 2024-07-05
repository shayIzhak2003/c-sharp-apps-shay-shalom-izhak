using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.sport_app
{
    public class GeneralPlayer
    {
        // Properties
        public int Points { get; set; }
        public string ScoreName { get; set; }
        public int Assists { get; set; }
        public int Fouls { get; set; }
        public bool OutOfGame { get; set; }
        public string GoalType { get; set; } // Added property for the goal type

        // Constructor
        public GeneralPlayer(string scoreName, int points = 0, int assists = 0, int fouls = 0, bool outOfGame = false, string goalType = "default goal")
        {
            ScoreName = scoreName;
            Points = points;
            Assists = assists;
            Fouls = fouls;
            OutOfGame = outOfGame;
            GoalType = goalType;
        }

        // Methods
        public virtual void ScoreField()
        {
            Points += 1; // Default points
            DisplayScore();
        }

        public void DisplayScore()
        {
            Console.WriteLine($"{ScoreName} scored a {GoalType} and now has {Points} points!");
        }

        public virtual void AddFoul()
        {
            Fouls += 1;
            Console.WriteLine("Foul added.");
        }
    }
}
