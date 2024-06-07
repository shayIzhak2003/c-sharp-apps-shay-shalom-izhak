using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.sport_app
{
    public class Round
    {
        private int roundNumber;
        private Game[] games;

        public Round(int roundNumber, int numberOfGames)
        {
            this.roundNumber = roundNumber;
            games = new Game[numberOfGames];
        }

        public int GetRoundNumber()
        {
            return roundNumber;
        }

        public void SetRoundNumber(int roundNumber)
        {
            this.roundNumber = roundNumber;
        }

        public Game[] GetGames()
        {
            return games;
        }

        public void AddGame(Game game, int index)
        {
            games[index] = game;
        }

        public override string ToString()
        {
            return $"Round {roundNumber}";
        }
    }
}
