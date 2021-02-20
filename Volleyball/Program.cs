using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 

            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double games = ((48 - h) * 3.0 / 4.0) + h + (p * 2.0 / 3.0);

            if (year == "leap")
            {
                games *= 1.15;
            }

            Console.WriteLine(Math.Floor(games));


            
        }
    }
}
