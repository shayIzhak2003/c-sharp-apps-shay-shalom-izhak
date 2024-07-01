using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.sport_app
{
    public class SoccerPlayer : GeneralPlayer
    {
        // Additional Properties
        public bool RedCard { get;  set; }
        public int Penalties { get;  set; }
        public int DribblingRate { get; set; } // 1 to 10 scale

        // Constructor
        public SoccerPlayer() : base("Goal")
        {
        }

        // Methods
        public void SetRedCard(bool redCard)
        {
            RedCard = redCard;
            if (RedCard)
            {
                OutOfGame = true;
                Console.WriteLine("Player received a red card and is out of the game.");
            }
        }

        public void ScorePenalty()
        {
            Points += 1; // 1 point for a penalty
            Penalties += 1;
            DisplayScore();
        }

        public override void AddFoul()
        {
            Fouls += 1;
            Console.WriteLine("Foul added.");
        }
    }
}
