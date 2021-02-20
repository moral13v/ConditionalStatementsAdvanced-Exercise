using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());

            double price = 0;

            // condition 1

            switch (season)
            {
                case "Spring":

                    price = 3000;

                    if (numberOfPeople <= 6)
                    {
                        price *=  0.9;
                    }
                    else if (numberOfPeople >= 7 && numberOfPeople <= 11)
                    {
                        price *= 0.85;
                    }
                    else
                    {
                        price *= 0.75;
                    }
                    break;
                case "Summer":
                case "Autumn":

                    price = 4200;

                    if (numberOfPeople <= 6)
                    {
                        price *= 0.9;
                    }
                    else if (numberOfPeople >= 7 && numberOfPeople <= 11)
                    {
                        price *= 0.85;
                    }
                    else
                    {
                        price *= 0.75;
                    }
                    break;
                case "Winter":

                    price = 2600;

                    if (numberOfPeople <= 6)
                    {
                        price *= 0.9;
                    }
                    else if (numberOfPeople >= 7 && numberOfPeople <= 11)
                    {
                        price *= 0.85;
                    }
                    else
                    {
                        price *= 0.75;
                    }
                    break;
            }

            // condition 2

            if (numberOfPeople % 2 == 0)
            {
                switch (season)
                {
                    case "Spring":
                    case "Summer":
                    case "Winter":
                        price *= 0.95;
                        break;
                }
            }

            // condition 3

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {(budget - price):f2} leva left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {(price - budget):f2} leva.");
            }

        }
    }
}
