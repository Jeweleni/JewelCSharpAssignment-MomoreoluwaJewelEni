using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator_Library
{
    public static class Calculator
    {
        public static void CalculatorStuff()
        {

            
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an operation (1-5): ");

                int choice = Convert.ToInt32(Console.ReadLine());


               
                if (choice == 5)
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                if (choice < 1 || choice > 5) // Validate input
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;


                //// Perform the operation
                ///
                switch (choice)
                {
                    case 1: // Addition
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;

                    case 2: // Subtraction
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;

                    case 3: // Multiplication
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;

                    case 4: // Division
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }

                Console.WriteLine();
            }
        }

    }
}
