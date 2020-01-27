using System;

namespace printPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());
            for (int i = startChar; i <= endChar; i++)
            {
                char currentChar = (char)i;
                Console.Write($"{currentChar} ");
            }
        }
    }
}
