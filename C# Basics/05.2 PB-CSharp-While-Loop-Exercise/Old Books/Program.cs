using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookSearch = Console.ReadLine();
            int bookCapacity = int.Parse(Console.ReadLine());

            string bookNext = "";
            int bookCount = 0;
            

            while (bookCount <= bookCapacity)
            {
                
                if (bookSearch == bookNext)
                {
                    Console.WriteLine($"You checked {bookCount-1} books and found it.");
                    return;
                }
                bookCount++;
                bookNext = Console.ReadLine();
                
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {bookCapacity} books.");
        }
    }
}
