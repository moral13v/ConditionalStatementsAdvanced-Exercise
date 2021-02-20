using System;

namespace summer_outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeofday = (Console.ReadLine());
            string outfit = "";
            string shoes = "";


            if (degrees <= 10 || degrees <= 18)
            {
                switch (timeofday)
                {
                    case "Morning":
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        break;
                    case "Afternoon":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
            else if (degrees < 18 || degrees <= 24)
            {
                switch (timeofday)
                {
                    case "Morning":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;

                }
            }
            else if (degrees <= 25)
            {
                switch (timeofday)
                {
                    case "Morning":
                        outfit = "T-shirt";
                        shoes = "Sandals";
                        break;
                    case "Afternoon":
                        outfit = "Swimsuit";
                        shoes = "Barefoot";
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;


                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");

        }


    }
}