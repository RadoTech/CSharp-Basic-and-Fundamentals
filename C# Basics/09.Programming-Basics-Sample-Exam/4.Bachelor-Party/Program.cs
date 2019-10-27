using System;

namespace BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int guestMusicianMoney = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int peopleOneGroup = 0;
            int peopleAllGroups = 0;
            int peopleAllGroupsMoney = 0;


            while (command != "The restaurant is full")
            {
                peopleOneGroup = int.Parse(command);
                peopleAllGroups += peopleOneGroup;
                if (peopleOneGroup >= 5)
                {
                    peopleAllGroupsMoney += peopleOneGroup * 70;
                }
                else if (peopleOneGroup < 5)
                {
                    peopleAllGroupsMoney += peopleOneGroup * 100;
                }
                command = Console.ReadLine();
            }
            if (peopleAllGroupsMoney >= guestMusicianMoney)
            {
                Console.WriteLine($"You have {peopleAllGroups} guests and {peopleAllGroupsMoney - guestMusicianMoney} leva left.");
            }
            else if (peopleAllGroupsMoney < guestMusicianMoney)
            {
                Console.WriteLine($"You have {peopleAllGroups} guests and {peopleAllGroupsMoney} leva income, but no singer.");

            }
        }
    }
}
