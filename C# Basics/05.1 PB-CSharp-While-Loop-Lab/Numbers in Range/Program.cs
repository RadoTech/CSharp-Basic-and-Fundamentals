using System;

namespace NumbersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int number = int.Parse(Console.ReadLine());

            //logic

            while (number < 1 || number > 100)
            {
                Console.WriteLine("Invalid number!");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {number}");
        }
    }
}
