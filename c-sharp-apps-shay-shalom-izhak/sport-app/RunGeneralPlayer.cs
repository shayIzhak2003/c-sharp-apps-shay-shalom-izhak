using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.sport_app
{
    public class RunGeneralPlayer
    {
        public static void RunMain()
        {
            // Example players
            BasketBallPlayer basketballPlayer = new BasketBallPlayer();
            SoccerPlayer soccerPlayer = new SoccerPlayer();

            // Simulate some actions
            basketballPlayer.ScoreField(); // Adds 2 points
            basketballPlayer.Score3();     // Adds 3 points
            basketballPlayer.AddFoul();    // Adds 1 foul

            soccerPlayer.ScoreField();     // Adds 1 point
            soccerPlayer.AddFoul();        // Adds 1 foul
            soccerPlayer.SetRedCard(true); // Player gets a red card
        }
    }
}
