using c_sharp_apps_shay_shalom_izhak.sport_app;
using SoccerLeagueApp;
using System;

namespace c_sharp_apps_Akiva_Cohen.sport_app
{
    public class TestSportApp
    {
        public static void Test1()
        {
            Console.WriteLine("Test 1 - Champions League Mock");
            Season[] groups = CreateChampionsLeagueMock();

            for (int i = 0; i < groups.Length; i++)
            {
                groups[i].DisplayTable();
            }
        }

        public static Season[] CreateChampionsLeagueMock()
        {
            Season[] groups = new Season[8];

            // Group A
            Team bayern = new Team("Bayern", "Bayern", "Champions League");
            Team copenhagen = new Team("Copenhagen", "Copenhagen", "Champions League");
            Team galatasaray = new Team("Galatasaray", "Istanbul", "Champions League");
            Team manUnited = new Team("Man United", "Manchester", "Champions League");
            Team[] teams1 = { bayern, copenhagen, galatasaray, manUnited };
            Season groupA = new Season(2024, "Soccer", "Champions - Group A", 6, teams1.Length);
            groupA.SetTeams(teams1);
            bayern.UpdateStatistics(15, 30, 10, 4, 14);
            copenhagen.UpdateStatistics(12, 25, 15, 4, 14);
            galatasaray.UpdateStatistics(9, 20, 20, 4, 14);
            manUnited.UpdateStatistics(18, 35, 12, 4, 14);
            groups[0] = groupA;

            // Group B
            Team arsenal = new Team("Arsenal", "London", "Champions League");
            Team psv = new Team("PSV", "Eindhoven", "Champions League");
            Team lens = new Team("Lens", "Lens", "Champions League");
            Team sevilla = new Team("Sevilla", "Sevilla", "Champions League");
            Team[] teams2 = { arsenal, psv, lens, sevilla };
            Season groupB = new Season(2024, "Soccer", "Champions - Group B", 6, teams2.Length);
            groupB.SetTeams(teams2);
            arsenal.UpdateStatistics(16, 32, 11, 4, 14);
            psv.UpdateStatistics(10, 22, 18, 4, 14);
            lens.UpdateStatistics(12, 28, 14, 4, 14);
            sevilla.UpdateStatistics(8, 20, 21, 4, 14);
            groups[1] = groupB;

            // Group C
            Team realMadrid = new Team("Real Madrid", "Madrid", "Champions League");
            Team napoli = new Team("Napoli", "Naples", "Champions League");
            Team braga = new Team("Braga", "Braga", "Champions League");
            Team unionBerlin = new Team("Union Berlin", "Berlin", "Champions League");
            Team[] teams3 = { realMadrid, napoli, braga, unionBerlin };
            Season groupC = new Season(2024, "Soccer", "Champions - Group C", 6, teams3.Length);
            groupC.SetTeams(teams3);
            realMadrid.UpdateStatistics(20, 36, 8, 4, 14);
            napoli.UpdateStatistics(14, 28, 13, 4, 14);
            braga.UpdateStatistics(10, 22, 18, 4, 14);
            unionBerlin.UpdateStatistics(8, 19, 22, 4, 14);
            groups[2] = groupC;

            // Group D
            Team realSociedad = new Team("Real Sociedad", "San Sebastián", "Champions League");
            Team inter = new Team("Inter", "Milan", "Champions League");
            Team benfica = new Team("Benfica", "Lisbon", "Champions League");
            Team salzburg = new Team("Salzburg", "Salzburg", "Champions League");
            Team[] teams4 = { realSociedad, inter, benfica, salzburg };
            Season groupD = new Season(2024, "Soccer", "Champions - Group D", 6, teams4.Length);
            groupD.SetTeams(teams4);
            realSociedad.UpdateStatistics(18, 33, 9, 4, 14);
            inter.UpdateStatistics(17, 31, 12, 4, 14);
            benfica.UpdateStatistics(12, 26, 16, 4, 14);
            salzburg.UpdateStatistics(6, 15, 30, 4, 14);
            groups[3] = groupD;

            // Group E
            Team lazio = new Team("Lazio", "Rome", "Champions League");
            Team feyenoord = new Team("Feyenoord", "Rotterdam", "Champions League");
            Team atléticoMadrid = new Team("Atlético Madrid", "Madrid", "Champions League");
            Team celtic = new Team("Celtic", "Glasgow", "Champions League");
            Team[] teams5 = { lazio, feyenoord, atléticoMadrid, celtic };
            Season groupE = new Season(2024, "Soccer", "Champions - Group E", 6, teams5.Length);
            groupE.SetTeams(teams5);
            lazio.UpdateStatistics(19, 34, 10, 4, 14);
            feyenoord.UpdateStatistics(12, 25, 15, 4, 14);
            atléticoMadrid.UpdateStatistics(15, 30, 13, 4, 14);
            celtic.UpdateStatistics(10, 20, 20, 4, 14);
            groups[4] = groupE;

            // Group F
            Team dortmund = new Team("Dortmund", "Dortmund", "Champions League");
            Team psg = new Team("PSG", "Paris", "Champions League");
            Team acMilan = new Team("AC Milan", "Milan", "Champions League");
            Team newcastle = new Team("Newcastle", "Newcastle", "Champions League");
            Team[] teams6 = { dortmund, psg, acMilan, newcastle };
            Season groupF = new Season(2024, "Soccer", "Champions - Group F", 6, teams6.Length);
            groupF.SetTeams(teams6);
            dortmund.UpdateStatistics(14, 29, 11, 4, 14);
            psg.UpdateStatistics(18, 35, 9, 4, 14);
            acMilan.UpdateStatistics(12, 24, 17, 4, 14);
            newcastle.UpdateStatistics(8, 20, 22, 4, 14);
            groups[5] = groupF;

            // Group G
            Team manchesterCity = new Team("Manchester City", "Manchester", "Champions League");
            Team rbLeipzig = new Team("RB Leipzig", "Leipzig", "Champions League");
            Team youngBoys = new Team("Young Boys", "Bern", "Champions League");
            Team crvena = new Team("Crvena Zvezda", "Belgrade", "Champions League");
            Team[] teams7 = { manchesterCity, rbLeipzig, youngBoys, crvena };
            Season groupG = new Season(2024, "Soccer", "Champions - Group G", 6, teams7.Length);
            groupG.SetTeams(teams7);
            manchesterCity.UpdateStatistics(20, 40, 8, 4, 14);
            rbLeipzig.UpdateStatistics(15, 28, 14, 4, 14);
            youngBoys.UpdateStatistics(9, 20, 19 ,13,3);
            crvena.UpdateStatistics(6, 15, 28, 4, 14);
            groups[6] = groupG;

            // Group H
            Team barcelona = new Team("Barcelona", "Barcelona", "Champions League");
            Team porto = new Team("Porto", "Porto", "Champions League");
            Team shakhtarDonetsk = new Team("Shakhtar Donetsk", "Donetsk", "Champions League");
            Team antwerpFc = new Team("Antwerp FC", "Antwerp", "Champions League");
            Team[] teams8 = { barcelona, porto, shakhtarDonetsk, antwerpFc };
            Season groupH = new Season(2024, "Soccer", "Champions - Group H", 6, teams8.Length);
            groupH.SetTeams(teams8);
            barcelona.UpdateStatistics(18, 38, 10, 4, 14);
            porto.UpdateStatistics(14, 29, 13, 4, 14);
            shakhtarDonetsk.UpdateStatistics(12, 25, 18 , 4, 14);
            antwerpFc.UpdateStatistics(8, 18, 22, 4, 14);
            groups[7] = groupH;

            return groups;
        }
    }
}
