using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayToStay = Console.ReadLine();
            decimal price = 0;
            if (dayToStay == "Friday")
            {
                if (typeGroup == "Students")
                {
                    price = 8.45M * peopleCount;
                    if (peopleCount >= 30)
                    {
                        price *= 0.85M;
                    }
                }
                else if (typeGroup == "Business")
                {
                    if (peopleCount < 100)
                    {
                        price = 10.90M * peopleCount;
                    }
                    else if (peopleCount >= 100)
                    {
                        price = ((peopleCount - 10) * 10.90M);
                    }
                }
                else if (typeGroup == "Regular")
                {
                    price = 15 * peopleCount;
                    if (peopleCount >= 10 && peopleCount <=20)
                    {
                        price *= 0.95M;
                    }
                }
            }
            else if (dayToStay == "Saturday")
            {
                if (typeGroup == "Students")
                {
                    price = 9.80M * peopleCount;
                    if (peopleCount >= 30)
                    {
                        price *= 0.85M;
                    }
                }
                else if (typeGroup == "Business")
                {
                    if (peopleCount < 100)
                    {
                        price = 15.60M * peopleCount;
                    }
                    else if (peopleCount >= 100)
                    {
                        price = ((peopleCount - 10) * 15.60M);
                    }
                }
                else if (typeGroup == "Regular")
                {
                    price = 20 * peopleCount;
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        price *= 0.95M;
                    }
                }
            }
            else if (dayToStay == "Sunday")
            {
                if (typeGroup == "Students")
                {
                    price = 10.46M * peopleCount;
                    if (peopleCount >= 30)
                    {
                        price *= 0.85M;
                    }
                }
                else if (typeGroup == "Business")
                {
                    if (peopleCount < 100)
                    {
                        price = 16 * peopleCount;
                    }  
                    else if (peopleCount >= 100)
                    {
                        price = ((peopleCount - 10) * 16);
                    }
                }
                else if (typeGroup == "Regular")
                {
                    price = 22.50M * peopleCount;
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        price *= 0.95M;
                    }
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
