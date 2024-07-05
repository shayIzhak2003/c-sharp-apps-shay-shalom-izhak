using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.sport_app
{
    public class BasketBallPlayer : GeneralPlayer
    {
        // Additional Properties
        public int Dunks { get; private set; }
        public int ThreeShots { get; private set; }
        public int Rebounds { get; private set; }

        // Constructor
        public BasketBallPlayer(string scoreName, int points, int assists, int fouls, bool outOfGame, string goalType, int dunks, int threeShots, int rebounds)
            : base(scoreName, points, assists, fouls, outOfGame, goalType)
        {
            Dunks = dunks;
            ThreeShots = threeShots;
            Rebounds = rebounds;
        }

        // Methods
        public override void ScoreField()
        {
            Points += 2; // 2 points for a field goal in basketball
            DisplayScore();
        }

        public void Score3()
        {
            Points += 3; // 3 points for a three-point shot
            ThreeShots += 1;
            DisplayScore();
        }

        public override void AddFoul()
        {
            Fouls += 1;
            Console.WriteLine("Foul added.");
            if (Fouls >= 5)
            {
                OutOfGame = true;
                Console.WriteLine("Player fouled out.");
            }
        }
    }
}
