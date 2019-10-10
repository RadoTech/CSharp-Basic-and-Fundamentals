using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string nickname = Console.ReadLine();
            string passwordSet = Console.ReadLine();

            string enterPassword = Console.ReadLine();
            
            while (enterPassword != passwordSet )
            {
                enterPassword = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {nickname}!");
        }
    }
}
