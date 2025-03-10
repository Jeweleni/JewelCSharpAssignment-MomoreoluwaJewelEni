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
            Console.Write("Enter a few words separated by a space: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input. Please enter at least one word.");
                return;
            }

            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string pascalCase = string.Concat(words
                .Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));

            Console.WriteLine($"PascalCase variable name: {pascalCase}");
        }

    }
}
