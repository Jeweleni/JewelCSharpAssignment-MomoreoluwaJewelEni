using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question3
{
    public static class questionC
    {

        /// <summary>
        /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        /// </summary>
        public static void C()
        {

            //// Ask the user to enter 5 numbers

            List<int> numbers = new List<int>();


            //// Validate input
            while (numbers.Count < 5)
            {
                Console.Write($"Enter number {numbers.Count + 1}/5: ");
                string input = Console.ReadLine();

                //// Check if the input is a number

                if (int.TryParse(input, out int number))
                {
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("You've already entered that number. Please try again.");
                    }
                    else
                    {

                        numbers.Add(number);
                    }
                }

                //// If the input is not a number
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            numbers.Sort();

            //// Display the sorted numbers

            Console.WriteLine("Sorted numbers:");
            Console.WriteLine(string.Join(", ", numbers));
        }

    }
}
