using System;

namespace Graduation
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

            while (year <= yearAll)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade >= gradePass)
                {
                    year++;
                    totalGradeSum += grade;
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
