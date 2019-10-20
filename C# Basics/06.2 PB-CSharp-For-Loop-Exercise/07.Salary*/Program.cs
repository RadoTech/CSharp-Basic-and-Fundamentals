using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int fine = 0;

            for (int n = 1; n <= openTabs; n++)
            {
                string webName = Console.ReadLine();
                switch (webName)
                {
                    case "Facebook": fine += 150; break;
                    case "Instagram": fine += 100; break;
                    case "Reddit": fine += 50; break;
                }
                if (fine >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            if (fine < salary)
            {
                int restSalary = salary - fine;
                Console.WriteLine($"{restSalary}");
            }
            else if (fine >= salary)
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}
