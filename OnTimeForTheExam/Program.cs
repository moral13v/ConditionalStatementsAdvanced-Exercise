using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int totalExamTime = examHour * 60 + examMinute;
            int totalArrivalTime = arrivalHour * 60 + arrivalMinute;

            if (totalArrivalTime > totalExamTime)
            {
                Console.WriteLine("Late");
                if ((totalArrivalTime - totalExamTime) < 60)
                {
                    Console.WriteLine($"{(totalArrivalTime - totalExamTime)} minutes after the start");
                }

                else
                {
                    int hoursLate = (totalArrivalTime - totalExamTime) / 60;
                    int minutesLate = (totalArrivalTime - totalExamTime) % 60;

                    Console.WriteLine($"{hoursLate}:{minutesLate:d2} hours after the start");
                }
            }

            else if (examHour == arrivalHour && examMinute == arrivalMinute)
            {
                Console.WriteLine("On time");
            }

            else if ((totalExamTime - totalArrivalTime) <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{(totalExamTime - totalArrivalTime)} minutes before the start");
            }

            else if (totalArrivalTime < totalExamTime)
            {
                Console.WriteLine("Early");
                if ((totalExamTime - totalArrivalTime) < 60)
                {
                    Console.WriteLine($"{(totalExamTime - totalArrivalTime)} minutes before the start");
                }
                else
                {
                    int hoursEarly = (totalExamTime - totalArrivalTime) / 60;
                    int minutesEarly = (totalExamTime - totalArrivalTime) % 60;

                    Console.WriteLine($"{hoursEarly}:{minutesEarly:d2} hours before the start");
                }
            }




            // conditions


        }
    }
}
