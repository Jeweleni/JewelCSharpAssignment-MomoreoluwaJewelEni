using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question2
{
    public static class questionV
    {
        public static void V()
        {

            Console.Write("Enter a series of numbers separated by commas: ");
            string input = Console.ReadLine();

            string[] numberStrings = input.Split(',');

            int[] numbers = numberStrings.Select(s => int.Parse(s.Trim())).ToArray();

            int maxNumber = numbers.Max();

            Console.WriteLine($"The maximum number is: {maxNumber}");
        }

    }
}
