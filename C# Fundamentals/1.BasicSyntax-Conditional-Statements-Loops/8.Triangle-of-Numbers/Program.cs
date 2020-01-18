using System;

namespace triangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string print = String.Empty;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int collumns = 1; collumns <= rows; collumns++)
                {
                    print += (rows + " ");
                }
                Console.Write(print);   
                Console.WriteLine();
                print = String.Empty;
            }
        }
    }
}
