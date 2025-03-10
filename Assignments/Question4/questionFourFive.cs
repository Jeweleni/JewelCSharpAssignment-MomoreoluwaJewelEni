using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question4
{
    public static class questionFourFive
    {

        /// <summary>
        /// Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word.
        /// </summary>
        public static void FourFive()
        {

            //// Ask the user to enter an English word
            Console.Write("Enter an English word: ");
            string input = Console.ReadLine();

            //// Validate input

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            //// Count the number of vowels in the word
            int vowelCount = input.ToLower().Count(c => "aeiou".Contains(c));

            Console.WriteLine($"Number of vowels: {vowelCount}");
        }

    }
}
