using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question4
{
    public static class questionFourFour
    {
        public static void FourFour()
        {

            //// Ask the user to enter a few words separated by a space
            Console.Write("Enter a few words separated by a space: ");
            string input = Console.ReadLine();


            //// Validate input
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input. Please enter at least one word.");
                return;
            }

            //// Convert input to an array of words

            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //// Convert the words to PascalCase
            string pascalCase = string.Concat(words
                .Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));


            //// Output the result
            Console.WriteLine($"PascalCase variable name: {pascalCase}");
        }

    }
}
