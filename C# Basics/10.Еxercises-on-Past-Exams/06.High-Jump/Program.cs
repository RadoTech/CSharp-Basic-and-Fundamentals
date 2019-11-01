using System;

namespace HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input:

            int desiredJump = int.Parse(Console.ReadLine());

            //Logic
            int startJump = desiredJump - 30;
            int currentJump = 0;
            int faultJumpsCounter = 0;
            int allJumpsCouter = 0;
            bool win = false;

            while (currentJump <= desiredJump || startJump <= desiredJump)
            {
                currentJump = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 3; i++)
                {

                    if (currentJump >= (startJump + 1))
                    {
                        allJumpsCouter++;
                        startJump += 5;
                        faultJumpsCounter = 0;
                        break;
                    }
                    else if (currentJump < (startJump + 1))
                    {
                        faultJumpsCounter++;
                        allJumpsCouter++;
                        if (faultJumpsCounter == 3)
                        {
                            //Output:
                            Console.WriteLine($"Tihomir failed at {startJump}cm after {allJumpsCouter} jumps.");
                            return;
                        }
                    }
                    if ((currentJump > desiredJump) && (startJump == desiredJump))
                    {
                        win = true;
                        break;
                    }
                    currentJump = int.Parse(Console.ReadLine());
                }
                if (win)
                {
                    break;
                }
            }
            //Output

            Console.WriteLine($"Tihomir succeeded, he jumped over {desiredJump}cm after {allJumpsCouter} jumps.");
        }
    }
}
