using System;

namespace EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreadsCount = int.Parse(Console.ReadLine());
            
            
            int vote = 0;
            int bestvote = 0;
            string bestChef = string.Empty;
            int currentVotes = 0;

            string chefName = Console.ReadLine();
            string command = Console.ReadLine();

            for (int currentBread = 1; currentBread <= easterBreadsCount; currentBread++)
            {
                
                while (command != "Stop")
                {
                    vote += int.Parse(command);
                    command = Console.ReadLine();
                    currentVotes = vote;

                    if (command == "Stop")
                    {
                        
                        Console.WriteLine($"{chefName} has {currentVotes} points.");

                        if (vote > bestvote)
                        {
                            Console.WriteLine($"{chefName} is the new number 1!");
                            bestvote = vote;
                            bestChef = chefName;
                        }
                        vote = 0;
                    }
                }
                if (currentBread == easterBreadsCount)
                {
                    break;
                }
                chefName = Console.ReadLine();
                command = Console.ReadLine();

            }
            Console.WriteLine($"{bestChef} won competition with {bestvote} points!");
        }
    }
}
