using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question1
{
    /// <summary>
    /// Write a program and ask the user to enter two numbers. Find the maximum of the two numbers.
    /// </summary>
    public static class questionTwo
    {

        public static void Two()
        {
            //// Ask the user to enter two numbers

            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            //// Get the second number
            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            //// Find the maximum of the two numbers
            int max = (number1 > number2) ? number1 : number2;

            Console.WriteLine($"The maximum of {number1} and {number2} is: {max}");
        }

    }
}
