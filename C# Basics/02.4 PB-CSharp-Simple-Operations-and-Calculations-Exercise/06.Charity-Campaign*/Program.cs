using System;

namespace Exercise6CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //1.Броят на дните, в които тече кампанията – цяло число в интервала [0 … 365]
            //2.Броят на сладкарите – цяло число в интервала[0 … 1000]
            //3.Броят на тортите – цяло число в интервала[0… 2000]
            //4.Броят на гофретите – цяло число в интервала[0 … 2000]
            //5.Броят на палачинките – цяло число в интервала[0 … 2000]

            int daysOfCampaign = int.Parse(Console.ReadLine());
            int cooksCount = int.Parse(Console.ReadLine());
            int cakesCount = int.Parse(Console.ReadLine());
            int gofrettiCount = int.Parse(Console.ReadLine());
            int pancakesCount = int.Parse(Console.ReadLine());

            //logic 
            //Sum of cakes + gofretti + pancakes by one cook for one day
            //Price: cake 45 BGN; gofretti 5.80; pancake = 3.20
            // 1/8 from the TotalSum will be spended to cover the expenses

            double cakePrice = 45;
            double gofrettiPrice = 5.80;
            double pancakesPrice = 3.20;

            double SumOfOneCookProductionForOneDay = (cakesCount * cakePrice) + (gofrettiCount * gofrettiPrice)
                                                   + (pancakesCount * pancakesPrice);
            double SumOfOneCookProductionAllDays = SumOfOneCookProductionForOneDay * daysOfCampaign;
            double SumOfAllCooksAllDays = SumOfOneCookProductionAllDays * cooksCount;
            double AllExpensesRate = 0.125;
            double SumOfAllExpenses = SumOfAllCooksAllDays * AllExpensesRate;
            double SumOfCharity = SumOfAllCooksAllDays - SumOfAllExpenses;

            //output
            //Sum of charity collected formated up to the second symbol after ,

            Console.WriteLine($"{SumOfCharity:F2}");
                                                         
        }
    }
}
