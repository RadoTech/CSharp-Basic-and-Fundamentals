using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string enterPassword = Console.ReadLine();
            string password = String.Empty;
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }
            if (enterPassword != password)
            {
                for (int attempt = 1; attempt <= 4; attempt++)
                {
                    if (attempt == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        return;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    enterPassword = Console.ReadLine();
                    if (enterPassword == password)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"User {userName} logged in.");
        }
    }
}
