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
        public int Points { get;  set; }
        public string ScoreName { get; set; }
        public int Assists { get; set; }
        public int Fouls { get; set; }
        public bool OutOfGame { get; set; }

        // Constructor
        public GeneralPlayer(string scoreName)
        {
            ScoreName = scoreName;
        }

        // Methods
        public virtual void ScoreField()
        {
            Points += 1; // Default points
            DisplayScore();
        }

        public void DisplayScore()
        {
            Console.WriteLine($"{ScoreName} scored a point!");
        }

        public virtual void AddFoul()
        {
            Fouls += 1;
            Console.WriteLine("Foul added.");
        }
    }
}
