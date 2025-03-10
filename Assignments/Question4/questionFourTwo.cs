using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question4
{
    public static class questionFourTwo
    {

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
        /// </summary>
        public static void FourTwo()
        {

            
            Console.Write("Enter a few numbers separated by a hyphen (or press Enter to exit): ");
            string input = Console.ReadLine();

            //// Validate input
           
            if (string.IsNullOrWhiteSpace(input))
                return;

            //// Convert input to an array of numbers
            int[] numbers = input.Split('-').Select(n => Convert.ToInt32(n)).ToArray();
            HashSet<int> uniqueNumbers = new HashSet<int>();


            //// Check if the numbers are consecutive
            foreach (int number in numbers)
            {

                if (!uniqueNumbers.Add(number))
                {
                    Console.WriteLine("Duplicate");
                    return;
                }
            }

            Console.WriteLine("No Duplicates");
        }

    }
}
