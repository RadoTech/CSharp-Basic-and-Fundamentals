using System;

namespace GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            string studentName = Console.ReadLine();

            //logic
            int year = 0;
            int yearAll = 12;
            double grade = 0.00;
            double totalGradeSum = 0.00;
            double totalGrade = 0.00;
            double gradePass = 4.00;
            int failCount = 0;
            int failCountYear = 0;

            while (year <= yearAll)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade >= gradePass)
                {
                    year++;
                    totalGradeSum += grade;
                }
                else if (grade < gradePass)
                {
                    failCount++;
                    if (failCount == 2)
                    {
                        failCountYear = ++year;
                        Console.WriteLine($"{studentName} has been excluded at {failCountYear} grade");
                        break;
                    }
                }

                if (year == yearAll)
                {
                    totalGrade = (totalGradeSum / yearAll);
                    Console.WriteLine($"{studentName} graduated. Average grade: {totalGrade:f2}");
                    break;
                }
            }
        }
    }
}
