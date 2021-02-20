using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double apartmentPrice = 0;
            double studioPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;

                    if (nights > 7 && nights <= 14)
                    {
                        studioPrice *= 0.95;
                    }
                    else if (nights > 14)
                    {
                        studioPrice *= 0.70; 
                    }

                    apartmentPrice = 65;
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;

                    if (nights > 14)
                    {
                        studioPrice *= 0.80;
                    }

                    apartmentPrice = 68.70;
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    break;
            }

            if (nights > 14)
            {
                apartmentPrice *= 0.90;
            }

            Console.WriteLine($"Apartment: {(nights * apartmentPrice):f2} lv.");
            Console.WriteLine($"Studio: {(nights * studioPrice):f2} lv.");
        }
    }
}
