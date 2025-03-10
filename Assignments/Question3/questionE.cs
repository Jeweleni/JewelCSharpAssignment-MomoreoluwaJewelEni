using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question3
{
    public static class questionE
    {

        /// <summary>
        /// Write a program and ask the user to enter at least 5 comma-separated numbers. If the user enters less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
        /// </summary>
        public static void E()
        {

            //// Ask the user to enter at least 5 comma-separated numbers
            while (true)
            {
                Console.Write("Enter at least 5 comma-separated numbers: ");
                string input = Console.ReadLine();

                List<int> numbers = input.Split(',')
                                         .Select(num => Convert.ToInt32(num.Trim()))
                                         .ToList();


                //// Validate input

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                }
                else
                {
                    numbers.Sort();
                    Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", numbers.Take(3)));
                    break;
                }
            }
        }

    }
}
