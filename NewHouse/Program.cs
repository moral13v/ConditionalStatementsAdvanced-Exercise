using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            string flowerSort = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            // conditions

            switch (flowerSort)
            {
                case "Roses":
                    if (quantity > 80)
                    {
                        price = 5 * 0.90;
                    }
                    else
                    {
                        price = 5;
                    }
                    break;
                case "Dahlias":
                    if (quantity > 90)
                    {
                        price = 3.80 * 0.85;
                    }
                    else
                    {
                        price = 3.80;
                    }
                    break;
                case "Tulips":
                    if (quantity > 80)
                    {
                        price = 2.80 * 0.85;
                    }
                    else
                    {
                        price = 2.80;
                    }
                    break;
                case "Narcissus":
                    if (quantity < 120)
                    {
                        price = 3 * 1.15;
                    }
                    else
                    {
                        price = 3;
                    }
                    break;
                case "Gladiolus":
                    if (quantity < 80)
                    {
                        price = 2.50 * 1.20;
                    }
                    else
                    {
                        price = 2.50;
                    }
                    break;
            }

            // calc

            double moneyNeeded = quantity * price;

            // condition

            if (budget >= moneyNeeded)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerSort} and {(budget - moneyNeeded):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(moneyNeeded - budget):f2} leva more.");
            }

        }
    }
}
