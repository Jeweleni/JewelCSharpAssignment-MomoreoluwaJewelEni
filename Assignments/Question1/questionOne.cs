using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question1
{
    public static class questionOne
    {
        /// <summary>
        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
        /// </summary>
        public static void One()
        {
            //// Ask the user to enter a number

            Console.Write("Enter a number between 1 and 10: ");
            int number = int.Parse(Console.ReadLine());

            //// Validate the input
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            //// If the input is not valid
            else
            {
                Console.WriteLine("Invalid");
            }
        }

    }
}
