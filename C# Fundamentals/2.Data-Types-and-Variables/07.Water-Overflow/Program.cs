using System;

namespace waterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int quantity = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= lines; i++)
            {
                sum += quantity;
                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= quantity;
                }
                if (i == lines)
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
