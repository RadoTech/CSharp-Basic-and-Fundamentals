using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string architectNames = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());

            //logic
            int hoursNeeded = projectsCount * 3;


            Console.WriteLine($"The architect {architectNames} will need {hoursNeeded} hours to complete {projectsCount} project/s.");
        }
    }
}
