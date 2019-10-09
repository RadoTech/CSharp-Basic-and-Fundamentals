using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int installments = int.Parse(Console.ReadLine());
            int firstInstallment = 1;
            double sum = 0.00;
            double totalSum = 0.00;

            while (firstInstallment <= installments)
            {
                sum = double.Parse(Console.ReadLine());

                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {totalSum:f2}");
                    break;
                }

                totalSum += sum;
                Console.WriteLine($"Increase: {sum:f2}");
                firstInstallment++;

                if (firstInstallment > installments)
                {
                    Console.WriteLine($"Total: {totalSum:f2}");
                }
            }
        }
    }
}
