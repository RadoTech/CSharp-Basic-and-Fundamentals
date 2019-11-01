using System;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clientsCount = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double basketPrice = 1.50;
            double wreathPrice = 3.80;
            double chocolateBunnyPrice = 7;

            double currentBill = 0;
            double totalBill = 0;

            int itemCounter = 0;


            for (int currentClient = 1; currentClient <= clientsCount; currentClient++)
            {
                while (command != "Finish")
                {
                    if (command == "basket")
                    {
                        currentBill += basketPrice;
                        itemCounter++;
                    }
                    else if (command == "wreath")
                    {
                        currentBill += wreathPrice;
                        itemCounter++;
                    }
                    else if (command == "chocolate bunny")
                    {
                        currentBill += chocolateBunnyPrice;
                        itemCounter++;
                    }

                    command = Console.ReadLine();

                    if (command == "Finish")
                    {
                        if (itemCounter % 2 == 0)
                        {
                            currentBill *= 0.8;
                        }
                        Console.WriteLine($"You purchased {itemCounter} items for {currentBill:f2} leva.");
                        totalBill += currentBill;
                        currentBill = 0;
                        itemCounter = 0;

                    }
                }
                if (currentClient == clientsCount)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Average bill per client is: {(totalBill / clientsCount):f2} leva.");
        }
    }
}
