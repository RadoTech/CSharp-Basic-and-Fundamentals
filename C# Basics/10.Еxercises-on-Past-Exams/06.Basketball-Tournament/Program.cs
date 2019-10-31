using System;

namespace BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            string tournamentName = Console.ReadLine();
            int gamesCount = int.Parse(Console.ReadLine());

            //Logic:

            int winPoints = 0;
            int lostPoints = 0;
            int winCounter = 0;
            int lostCounter = 0;
            string currentTournamentName = String.Empty;
            bool endOfTournament = false;

            while (tournamentName != "End of tournaments")
            {

                for (int currentGame = 1; currentGame <= gamesCount; currentGame++)
                {
                    winPoints = int.Parse(Console.ReadLine());
                    lostPoints = int.Parse(Console.ReadLine());
                    currentTournamentName = tournamentName;

                    if (winPoints > lostPoints)
                    {
                        winCounter++;
                        Console.WriteLine($"Game {currentGame} of tournament {currentTournamentName}: win with {winPoints - lostPoints} points.");
                        winPoints = 0;
                        lostPoints = 0;
                    }
                    else if (winPoints < lostPoints)
                    {
                        lostCounter++;
                        Console.WriteLine($"Game {currentGame} of tournament {currentTournamentName}: lost with {lostPoints - winPoints} points.");
                        winPoints = 0;
                        lostPoints = 0;
                    }
                    if (currentGame == gamesCount)
                    {
                        tournamentName = Console.ReadLine();
                        if (tournamentName == "End of tournaments")
                        {
                            endOfTournament = true;
                            break;
                        }
                        else
                        {
                            gamesCount = int.Parse(Console.ReadLine());
                            break;
                        }
                        
                    }

                    if (endOfTournament)
                    {
                        break;
                    }
                }
                
            }
            double allGames = winCounter + lostCounter;
            double winPercent = (winCounter / allGames) * 100;
            double lostPercent = (lostCounter / allGames) * 100;

            //Output:

            Console.WriteLine($"{winPercent:f2}% matches win");
            Console.WriteLine($"{lostPercent:f2}% matches lost");
        }
    }
}
