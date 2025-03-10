using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question4
{
    public static class questionFourOne
    {
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
        /// </summary>
        public static void FourOne()
        {
            // Ask the user to enter a few numbers separated by a hyphen
            Console.Write("Enter a few numbers separated by a hyphen: ");
            string input = Console.ReadLine();

            //// Validate input
            string[] numberStrings = input.Split('-');

            //// Convert input to an array of numbers
            int[] numbers = numberStrings.Select(s => int.Parse(s)).ToArray();
            
            //// Check if the numbers are consecutive
            bool isConsecutive = true;

            int direction = numbers[1] - numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {

                //// Check if the difference between the current number and the previous number is the same as the direction
                if (numbers[i] - numbers[i - 1] != direction)
                {
                    isConsecutive = false;
                    break;
                }
            }

            //// Output the result

            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }

    }
}
