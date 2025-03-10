using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question2
{
    public static class questionII
    {

        /// <summary>
        /// Write a program and ask the user to enter a few numbers. The program should print the sum of the numbers.
        /// </summary>
        public static void II()
        {

            //// Ask the user to enter a series of numbers separated by commas
            int sum = 0;

            //// Validate input
            while (true)
            {

                //// Ask the user to enter a number or 'ok' to exit
                Console.Write("Enter a number or 'ok' to exit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;
                }
                //// Validate input
                if (int.TryParse(input, out int number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'ok' to exit.");
                }
            }

            //// Output the sum of all entered numbers
            Console.WriteLine($"The sum of all entered numbers is: {sum}");
        }

    }
}
