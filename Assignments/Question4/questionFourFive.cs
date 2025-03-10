using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question4
{
    public static class questionFourFive
    {
        public static void FourFive()
        {
            Console.Write("Enter an English word: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            int vowelCount = input.ToLower().Count(c => "aeiou".Contains(c));

            Console.WriteLine($"Number of vowels: {vowelCount}");
        }

    }
}
