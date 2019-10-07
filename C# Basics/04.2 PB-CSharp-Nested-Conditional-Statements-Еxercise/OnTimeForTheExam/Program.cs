using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arrivalH = int.Parse(Console.ReadLine());
            int arrivalM = int.Parse(Console.ReadLine());

            //logic

            int examHtoM = examH * 60;
            int examHMtoM = examHtoM + examM;
            int arrivalHtoM = arrivalH * 60;
            int arrivalHMtoM = arrivalHtoM + arrivalM;
            int onTimeDifferenceM = examHMtoM - arrivalHMtoM;

            if (((examHMtoM - arrivalHMtoM) <= 30) && ((examHMtoM - arrivalHMtoM) >= 0))
            {
                if (examHMtoM == arrivalHMtoM)
                {
                    Console.WriteLine("On time");
                }
                else if (examHMtoM != arrivalHMtoM)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{onTimeDifferenceM} minutes before the start");
                }
            }
            else if ((examHMtoM - arrivalHMtoM) > 30)
            {

                int earlyDifferenceH = ((examHMtoM - arrivalHMtoM) / 60);
                int earlyDifferenceM = ((examHMtoM - arrivalHMtoM) % 60);

                if ((examHMtoM - arrivalHMtoM) < 60 && (examHMtoM - arrivalHMtoM) > 30)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{earlyDifferenceM} minutes before the start");
                }
                else if ((examHMtoM - arrivalHMtoM) >= 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{earlyDifferenceH}:{earlyDifferenceM:D2} hours before the start");
                }
            }
            else if ((arrivalHMtoM - examHMtoM) > 0)
            {
                bool lateMinutes = (((arrivalHMtoM - examHMtoM) > 0) && ((arrivalHMtoM - examHMtoM) < 60));
                bool lateHours = ((arrivalHMtoM - examHMtoM) >= 60);

                int lateDifferenceH = (arrivalHMtoM - examHMtoM) / 60;
                int lateDifferenceM = (arrivalHMtoM - examHMtoM) % 60;

                if (lateMinutes)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{lateDifferenceM} minutes after the start");
                }

                else if (lateHours)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{lateDifferenceH}:{lateDifferenceM:D2} hours after the start");
                }

            }



        }
    }
}
