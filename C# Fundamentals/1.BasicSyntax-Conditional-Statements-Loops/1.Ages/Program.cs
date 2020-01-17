using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string output = String.Empty;
            if (age >= 0 && age <= 2)
            {
                output = "baby";
            }
            else if (age > 2 && age <= 13)
            {
                output = "child";
            }
            else if (age > 13 && age <= 19)
            {
                output = "teenager";
            }
            else if (age > 19 && age <= 65)
            {
                output = "adult";
            }
            else if (age > 65)
            {
                output = "elder";
            }
            Console.WriteLine($"{output}");
        }
    }
}
