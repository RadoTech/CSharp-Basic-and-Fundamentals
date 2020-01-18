using System;

namespace vendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double insertedMoney = 0;
            while (command != "Start")
            {
                double currentCoin;
                Double.TryParse(command, out currentCoin);
                switch (currentCoin)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        insertedMoney += currentCoin;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {currentCoin}");
                        break;
                }
                command = Console.ReadLine();
            }
            string item = Console.ReadLine();
            while (item != "End")
            {
                if (item == "Nuts")
                {
                    if (insertedMoney >= 2.0)
                    {
                        insertedMoney -= 2.0;
                        Console.WriteLine($"Purchased {item.ToLower()}");
                    }
                    else if (insertedMoney < 2.0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (item == "Water")
                {
                    if (insertedMoney >= 0.7)
                    {
                        insertedMoney -= 0.7;
                        Console.WriteLine($"Purchased {item.ToLower()}");
                    }
                    else if (insertedMoney < 0.7)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (item == "Crisps")
                {
                    if (insertedMoney >= 1.5)
                    {
                        insertedMoney -= 1.5;
                        Console.WriteLine($"Purchased {item.ToLower()}");
                    }
                    else if (insertedMoney < 1.5)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (item == "Soda")
                {
                    if (insertedMoney >= 0.8)
                    {
                        insertedMoney -= 0.8;
                        Console.WriteLine($"Purchased {item.ToLower()}");
                    }
                    else if (insertedMoney < 0.8)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (item == "Coke")
                {
                    if (insertedMoney >= 1.0)
                    {
                        insertedMoney -= 1.0;
                        Console.WriteLine($"Purchased {item.ToLower()}");
                    }
                    else if (insertedMoney < 1.0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                item = Console.ReadLine();
            }
            Console.WriteLine($"Change: {insertedMoney:f2}");
        }
    }
}
