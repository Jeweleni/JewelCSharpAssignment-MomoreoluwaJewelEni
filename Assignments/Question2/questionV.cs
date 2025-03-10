using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question2
{
    public static class questionV
    {

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a comma. Find the maximum of the numbers.
        /// </summary>
        public static void V()
        {
            //// Ask the user to enter a series of numbers separated by commas

            Console.Write("Enter a series of numbers separated by commas: ");
            string input = Console.ReadLine();

            //// Convert the input to an array of numbers
            string[] numberStrings = input.Split(',');

            //// Convert the strings to numbers
            int[] numbers = numberStrings.Select(s => int.Parse(s.Trim())).ToArray();

            //// Find the maximum number
            int maxNumber = numbers.Max();

            //// Output the result
            Console.WriteLine($"The maximum number is: {maxNumber}");
        }

    }
}
