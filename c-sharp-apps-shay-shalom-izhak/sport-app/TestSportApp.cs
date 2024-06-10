using c_sharp_apps_shay_shalom_izhak.sport_app;
using System;

namespace SoccerLeagueApp
{
    public class TestSportApp
    {
        public static Season[] CreateChampionsLeagueMock()
        {
            // League 1: Premier League
            Team[] premierLeagueTeams = new Team[]
            {
                new Team("Manchester City", "Manchester"),
                new Team("Manchester United", "Manchester"),
                new Team("Liverpool", "Liverpool"),
                new Team("Chelsea", "London")
            };
            Season premierLeague = new Season(2024, "Soccer", "Premier League", 10, premierLeagueTeams.Length);
            premierLeague.SetTeams(premierLeagueTeams);

            // League 2: La Liga
            Team[] laLigaTeams = new Team[]
            {
                new Team("Real Madrid", "Madrid"),
                new Team("Barcelona", "Barcelona"),
                new Team("Atletico Madrid", "Madrid"),
                new Team("Sevilla", "Sevilla")
            };
            Season laLiga = new Season(2024, "Soccer", "La Liga", 10, laLigaTeams.Length);
            laLiga.SetTeams(laLigaTeams);

            // League 3: Bundesliga
            Team[] bundesligaTeams = new Team[]
            {
                new Team("Bayern Munich", "Munich"),
                new Team("Borussia Dortmund", "Dortmund"),
                new Team("RB Leipzig", "Leipzig"),
                new Team("Bayer Leverkusen", "Leverkusen")
            };
            Season bundesliga = new Season(2024, "Soccer", "Bundesliga", 10, bundesligaTeams.Length);
            bundesliga.SetTeams(bundesligaTeams);

            // League 4: Serie A
            Team[] serieATeams = new Team[]
            {
                new Team("Juventus", "Turin"),
                new Team("Inter Milan", "Milan"),
                new Team("AC Milan", "Milan"),
                new Team("Napoli", "Naples")
            };
            Season serieA = new Season(2024, "Soccer", "Serie A", 10, serieATeams.Length);
            serieA.SetTeams(serieATeams);

            // League 5: Ligue 1
            Team[] ligue1Teams = new Team[]
            {
                new Team("Paris Saint-Germain", "Paris"),
                new Team("Lyon", "Lyon"),
                new Team("Marseille", "Marseille"),
                new Team("Monaco", "Monaco")
            };
            Season ligue1 = new Season(2024, "Soccer", "Ligue 1", 10, ligue1Teams.Length);
            ligue1.SetTeams(ligue1Teams);

            // Return array of seasons
            return new Season[] { premierLeague, laLiga, bundesliga, serieA, ligue1 };
        }
    }
}
