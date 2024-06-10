using System;

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

        public int GetRoundNumber() => roundNumber;
        public void SetRoundNumber(int roundNumber) => this.roundNumber = roundNumber;

        public Game[] GetGames() => games;

        public void AddGame(Game game, int index)
        {
            if (index < 0 || index >= games.Length)
            {
                throw new IndexOutOfRangeException("Invalid game index.");
            }
            games[index] = game;
        }

        public override string ToString() => $"Round {roundNumber}";
    }
}
