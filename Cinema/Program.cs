using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input

            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0.0;

            switch(type)
            {
                case "Premiere":
                    price = 12.00;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5.00;
                    break;
            }

            Console.WriteLine($"{(rows * columns * price):f2} leva");
        }
    }
}
