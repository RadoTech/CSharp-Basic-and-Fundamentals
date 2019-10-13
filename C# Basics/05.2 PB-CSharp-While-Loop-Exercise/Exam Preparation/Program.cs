using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());

            int badGradesCount = 0;

            string problemName = "";
            string lastProblem = "";
            int grade = 0;
            double gradesSum = 0;
            int problemCount = 0;
            double averageGrade = 0;

            while (!(problemName == "Enough"))
            {
                lastProblem = problemName;
                
                if (badGradesCount == badGrades)
                {
                    Console.WriteLine($"You need a break, {badGrades} poor grades.");
                    return;

                }
                problemName = Console.ReadLine();

                if (problemName == "Enough")
                {
                    break;
                }

                grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    ++badGradesCount;
                }
                
                gradesSum += grade;
                problemCount++;

            }

            if (problemName == "Enough")
            {
                averageGrade = gradesSum / problemCount;

                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {problemCount}");
                Console.WriteLine($"Last problem: {lastProblem}");

            }


        }
    }
}
