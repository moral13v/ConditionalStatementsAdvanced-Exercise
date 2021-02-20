using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string mathOperator = Console.ReadLine();

            double result = 0;

            // Condition 1

            if (n2 == 0)
            {
                if (mathOperator == "/" || mathOperator == "%")
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
            }
            else
            {
                // Condition 2

                switch (mathOperator)
                {
                    case "+":
                        result = n1 + n2;
                        break;
                    case "-":
                        result = n1 - n2;
                        break;
                    case "*":
                        result = n1 * n2;
                        break;
                    case "/":
                        result = n1 / n2;
                        break;
                    case "%":
                        result = n1 % n2;
                        break;
                }

                // Condition 3

                switch (mathOperator)
                {
                    case "+":
                    case "-":
                    case "*":
                        if (result % 2 == 0)
                        {
                            Console.WriteLine($"{n1} {mathOperator} {n2} = {result} - even");
                        }

                        else
                        {
                            Console.WriteLine($"{n1} {mathOperator} {n2} = {result} - odd");
                        }
                        break;
                    case "/":
                        Console.WriteLine($"{n1} {mathOperator} {n2} = {result:f2}");
                        break;

                    default:
                        Console.WriteLine($"{n1} {mathOperator} {n2} = {result}");
                        break;
                }
            }



        }
    }
}
