
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question2
{

    /// <summary>
    /// Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
    /// </summary>
    public static class questionIII
    {

        public static void III()
        {

            //// Ask the user to enter a number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //// Compute the factorial of the number
            int factorial = 1;
            // Loop through the numbers from the input number to 1
            for (int i = number; i > 1; i--)
            {
                factorial *= i;
            }
            //// Output the result
            Console.WriteLine($"{number}! = {factorial}");
        }

    }
}
