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
            // Create a BasketBallPlayer instance
            var basketballPlayer = new BasketBallPlayer(
                scoreName: "Jordan",
                points: 10,
                assists: 5,
                fouls: 2,
                outOfGame: false,
                goalType: "field goal",
                dunks: 3,
                threeShots: 2,
                rebounds: 4
            );

            // Display initial state
            Console.WriteLine("Basketball Player Initial State:");
            DisplayPlayerStats(basketballPlayer);

            // Score a field goal
            basketballPlayer.ScoreField();

            // Score a three-point shot
            basketballPlayer.Score3();

            // Add a foul
            basketballPlayer.AddFoul();

            // Display updated state
            Console.WriteLine("\nBasketball Player Updated State:");
            DisplayPlayerStats(basketballPlayer);

            // Create a SoccerPlayer instance
            var soccerPlayer = new SoccerPlayer(
                scoreName: "Messi",
                points: 5,
                assists: 4,
                fouls: 1,
                outOfGame: false,
                goalType: "penalty",
                redCard: false,
                penalties: 1,
                dribblingRate: 8
            );

            // Display initial state
            Console.WriteLine("\nSoccer Player Initial State:");
            DisplayPlayerStats(soccerPlayer);

            // Score a penalty
            soccerPlayer.ScorePenalty();

            // Give a red card
            soccerPlayer.SetRedCard(true);

            // Display updated state
            Console.WriteLine("\nSoccer Player Updated State:");
            DisplayPlayerStats(soccerPlayer);

            // Pause console
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method to display player stats
        static void DisplayPlayerStats(GeneralPlayer player)
        {
            Console.WriteLine($"Name: {player.ScoreName}");
            Console.WriteLine($"Points: {player.Points}");
            Console.WriteLine($"Assists: {player.Assists}");
            Console.WriteLine($"Fouls: {player.Fouls}");
            Console.WriteLine($"OutOfGame: {player.OutOfGame}");
            Console.WriteLine($"GoalType: {player.GoalType}");

            if (player is BasketBallPlayer basketballPlayer)
            {
                Console.WriteLine($"Dunks: {basketballPlayer.Dunks}");
                Console.WriteLine($"ThreeShots: {basketballPlayer.ThreeShots}");
                Console.WriteLine($"Rebounds: {basketballPlayer.Rebounds}");
            }
            else if (player is SoccerPlayer soccerPlayer)
            {
                Console.WriteLine($"RedCard: {soccerPlayer.RedCard}");
                Console.WriteLine($"Penalties: {soccerPlayer.Penalties}");
                Console.WriteLine($"DribblingRate: {soccerPlayer.DribblingRate}");
            }
        }
    }
}
