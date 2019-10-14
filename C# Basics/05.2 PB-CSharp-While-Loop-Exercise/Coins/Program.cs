using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal restMoney = decimal.Parse(Console.ReadLine());

            int coins = 0;
            restMoney *= 100;

            decimal lev2 = 200;
            int lev1 = 100;
            int stotinki50 = 50;
            int stotinki20 = 20;
            int stotinki10 = 10;
            int stotinki5 = 5;
            int stotinki2 = 2;
            int stotinki1 = 1;

            while (restMoney > 0)
            {
                if (restMoney >= lev2)
                {
                    restMoney -= lev2;
                    ++coins;
                }
                else if (restMoney >= lev1)
                {
                    restMoney -= lev1;
                    ++coins;
                }
                else if (restMoney >= stotinki50)
                {
                    restMoney -= stotinki50;
                    ++coins;
                }
                else if (restMoney >= stotinki20)
                {
                    restMoney -= stotinki20;
                    ++coins;
                }
                else if (restMoney >= stotinki10)
                {
                    restMoney -= stotinki10;
                    ++coins;
                }
                else if (restMoney >= stotinki5)
                {
                    restMoney -= stotinki5;
                    ++coins;
                }
                else if (restMoney >= stotinki2)
                {
                    restMoney -= stotinki2;
                    ++coins;
                }
                else if (restMoney >= stotinki1)
                {
                    restMoney -= stotinki1;
                    ++coins;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
