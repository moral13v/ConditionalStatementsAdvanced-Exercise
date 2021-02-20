using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double expence = 0;
            string destination = "";
            string venue = "";

            // Condition

            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        expence = budget * 0.30;
                        venue = "Camp";
                        break;
                    case "winter":
                        expence = budget * 0.70;
                        venue = "Hotel";
                        break;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        expence = budget * 0.40;
                        venue = "Camp";
                        break;
                    case "winter":
                        expence = budget * 0.80;
                        venue = "Hotel";
                        break;
                }
            }
            else
            {
                destination = "Europe";
                expence = budget * 0.90;
                venue = "Hotel";
            }

            // Output

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{venue} - {expence:f2}");
        }
    }
}
